using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace BindingExample
{
    public class RadCalendarUkraineLocalizationProvider : CalendarLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case CalendarStringId.CalendarClearButton:
                    return "Очистити";
                case CalendarStringId.CalendarTodayButton:
                    return "Сьогодні";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}
