using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IvanListener;
using CryptCommon.Interfaces;

namespace CrypTool.Tools
{
    public partial class ToolTLV : UserControl, ITool
    {


        public ToolTLV()
        {
            InitializeComponent();
        }

        public void InitTool(string pathToConfig)
        {
            
        }

        public class VivoGroup
        {
            public List<TLVTemplate> tlvs = new List<TLVTemplate>();
            public int GroupIndex = 0;

            public void BuildString(StringBuilder sb)
            {
                sb.AppendFormat("Group {0}\r\n", GroupIndex);
                foreach (var t in tlvs)
                {
                    sb.Append(t);
                }
            }
        }

        public void ProcessData(byte[] data, out string result)
        {
            byte[] src = data;
            StringBuilder sb = new StringBuilder();
            List<TLVTemplate> tlv = new List<TLVTemplate>();
            TlvParseException lastEx = null;

            tlv = TLVTemplate.ParseAll(src, new ParseFixes() { TreatFFAsPrimitive = chkViVO.Checked }, out lastEx);

            PrintParsedTlv(tlv, sb);
            if (lastEx != null)
            {

                sb.Append(lastEx);
            }

            result = sb.ToString();
        }

        public string GetName()
        {
            return "TLV";
        }

        public Control GetControl()
        {
            return this;
        }

        private void PrintParsedTlv(List<TLVTemplate> tlv, StringBuilder sb)
        {
            if (chkViVO.Checked)
            {
                List<VivoGroup> groups = new List<VivoGroup>();
                VivoGroup g = null;
                foreach (var t in tlv)
                {
                    if (t.TagName == "FFE4")
                    {
                        g = new VivoGroup { GroupIndex = t.Value[0] };
                        groups.Add(g);
                    }
                    else if (g != null)
                    {
                        g.tlvs.Add(t);
                    }
                }

                foreach (var group in groups)
                {
                    group.tlvs.Sort(new TLVDataSorter());
                    group.BuildString(sb);
                }
            }
            else
            {
                tlv.Sort(new TLVDataSorter());
                foreach (var t in tlv)
                {
                    sb.Append(t);
                }
            }
        }
    }
}
