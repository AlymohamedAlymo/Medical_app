using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace DoctorERP_v3_00
{
    public class NullableSpinEditor : RadSpinEditor
    {
        public NullableSpinEditor()
        {
            this.EnableNullValueInput = true;
        }
    }  
}
