using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DOAN_CLOUND.Models
{
    public class KhachHang
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("MaNV")]
        public string MaNV { get; set; }

        [BsonElement("HoTen")]
        public string HoTen { get; set; }

        [BsonElement("GioiTinh")]
        public string GioiTinh { get; set; }

        [BsonElement("ChucVu")]
        public string ChucVu { get; set; }
    }
}