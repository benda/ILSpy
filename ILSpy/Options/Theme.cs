using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICSharpCode.ILSpy.Options
{
   public class Theme
    {
		public string Name { get; }
		public Uri Uri { get; }

		public Theme(string name,Uri uri)
		{
			Name = name;
			Uri = uri;
		}
    }
}
