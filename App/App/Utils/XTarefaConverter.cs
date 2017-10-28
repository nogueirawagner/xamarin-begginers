﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Utils
{
  public class XTarefaConverter : XBooleanConvert
  {
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if ((bool)value)
        return "Finalizado";
      else
        return "Aberto";
    }
  }
}
