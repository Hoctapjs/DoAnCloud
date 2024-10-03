using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;


namespace DOAN_CLOUND.Models
{
    public class KhachHangRepository
    {
        private readonly IMongoCollection<KhachHang> _khachHangCollection;

        public KhachHangRepository()
        {
            // Chuỗi kết nối đến MongoDB
            var client = new MongoClient("mongodb+srv://susu123:Susu123@thanhson.9xd9p.mongodb.net/");
            var database = client.GetDatabase("thanhson"); // Tên database là QL_CAPHE
            _khachHangCollection = database.GetCollection<KhachHang>("khach"); // Tên collection là KHACH
        }

        public List<KhachHang> GetAll()
        {
            return _khachHangCollection.Find(khach => true).ToList();
        }

        public KhachHang GetById(string id)
        {
            return _khachHangCollection.Find(khach => khach.Id == id).FirstOrDefault();
        }

        public void Add(KhachHang khachHang)
        {
            _khachHangCollection.InsertOne(khachHang);
        }

        public void Update(string id, KhachHang khachHang)
        {
            _khachHangCollection.ReplaceOne(khach => khach.Id == id, khachHang);
        }

        public void Delete(string id)
        {
            _khachHangCollection.DeleteOne(khach => khach.Id == id);
        }
    }
}