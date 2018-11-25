using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICSharpCode.ILSpy.Options
{
	class Themes
	{
		public static readonly Theme Standard = new Theme("Standard", new Uri("pack://application:,,,/ILSpy;component/Themes/generic.xaml"));
		public static readonly Theme Dark = new Theme("Dark", new Uri("pack://application:,,,/ILSpy;component/Themes/Dark.xaml"));

		public static IEnumerable<Theme> GetAll()
		{
			return new Theme[] { Standard, Dark };
		}
	}
}
