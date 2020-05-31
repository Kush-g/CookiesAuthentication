using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class Picture
	{
		public int Id { get; set; }
		public string MimeType { get; set; }
		public string SeoFilename { get; set; }
		public string AltAttribute { get; set; }
		public string TitleAttribute { get; set; }
		public bool IsNew { get; set; }
		public string VirtualPath { get; set; }
	}
	public class PictureBinary
	{
		public int Id { get; set; }
		public int PictureId { get; set; }
		public byte[] BinaryData { get; set; }
	}
}
