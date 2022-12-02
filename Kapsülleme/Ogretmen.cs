using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    internal class Ogretmen
    {
        // Gelen veriyi büyük harfe döndürme

        private string ADSOYAD;

		public string adsoyad
		{
			get { return ADSOYAD; }
			set { ADSOYAD = value.ToUpper(); }
		}

		// TC Kimlik numarası gizleme

		private string TC;
		
		public string tc
		{
			get { return TC; }
			set { TC = value.Substring(0,3) + "********"; }
		}

		// Unvan bilgisini gösterme

		private string UNVAN;

		public string unvan
		{
			get { return UNVAN; }
			set {
				if (value == "")
					UNVAN = "Öğretmen";
				else
					UNVAN = value;
			}
		}

	}
}
