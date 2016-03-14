using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptCommon
{
    public class EasyCombo<T> : ComboBox
    {
        Dictionary<int,T> easyObjects = new Dictionary<int, T>();

        protected override void InitLayout()
        {
            base.InitLayout();
            DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void AddItem(T item)
        {
            AddItem(item.ToString(),item);
        }
        public void AddItem(string name, T item)
        {
            Items.Add(name);
            easyObjects.Add(Items.Count-1,item);
        }

        public T EasySelectedObject
        {
            get
            {
                if (!easyObjects.ContainsKey(SelectedIndex))
                    return default(T);
                return easyObjects[SelectedIndex];
            }
        }


    }
}
