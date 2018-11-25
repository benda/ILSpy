using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ICSharpCode.ILSpy.Options
{
    class ThemeManager
    {
		public static void SetTheme(Theme theme)
		{
			ResourceDictionary themeResourceDictionary = new ResourceDictionary();
			themeResourceDictionary.Source = theme.Uri;

			ApplyTheme(themeResourceDictionary, Application.Current.Resources);
		}


		private static void ApplyTheme(ResourceDictionary source,ResourceDictionary target)
		{
			target.BeginInit();
			target.MergedDictionaries.Clear();
			target.MergedDictionaries.Add(source);
			target.EndInit();
		}
	}
}
