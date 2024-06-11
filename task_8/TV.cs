namespace task_8
{
	public class TV
	{
		public string Vendor, Series, Model;
		public string SerialNo;
		public decimal ScreenSize;
		public bool hasHDMI, hasT2;
		public decimal Price;

		public TV()
		{
			Vendor = "Unknown"; Series = ""; Model = "Generic";
			SerialNo = "<not specified>";
			ScreenSize = 15; Price = 0;
            hasHDMI = false; hasT2 = false;
		}

		public TV(string Vendor, string Series, string Model, string SerialNo,
            decimal ScreenSize, bool hasHDMI, bool hasT2, decimal Price)
		{
			this.Vendor = Vendor;
			this.Series = Series;
			this.Model = Model;
			this.SerialNo = SerialNo;
			this.ScreenSize = ScreenSize;
			this.hasHDMI = hasHDMI;
			this.hasT2 = hasT2;
			this.Price = Price;
		}

		public string getFullName()
		{
			return $"{Vendor}, серія {Series}, модель {Model}\nСерійний номер: {SerialNo}";
		}

		public string getDescription()
		{
			return $"Діагональ екрану: {ScreenSize}, " +
				(hasT2 ? "вбудований приймач Т2, " : "") +
				(hasHDMI ? "порт HDMI для зовнішніх пристроїв" : "");
		}

		public decimal getPricePerInch()
		{
			return (decimal)Math.Round(Price / ScreenSize);
		}
	}
}

