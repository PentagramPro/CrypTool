﻿using CryptCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrypTool.Tools
{
  public interface ITool
  {
    void ProcessData(byte[] data, out string result);
    ISettings Settings { get; set; }
    string GetName();
    Control GetControl();
  }
}
