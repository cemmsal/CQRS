using CQRSExample.Entities;
using System;
using System.Collections.Generic;

namespace CQRSExample.Data
{
    public static class AppDbContext
    {
        static List<Book> bookList = new List<Book> {
         new() { Id = Guid.NewGuid(), Name = "Simyacı", Author="Paulo Coelho", Price = 27, Qty = 10, CreatedDate = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Yüzyıllık Yalnızlık", Author="Gabriel García Márquez", Price = 49.8M, Qty = 20, CreatedDate = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Suç ve Ceza", Author="Fyodor Dostoyevski", Price = 32, Qty = 30, CreatedDate = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Dönüşüm", Author="Franz Kafka", Price = 8.2M, Qty = 40, CreatedDate = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Küçük Prens", Author="Antoine de Saint-Exupéry" , Price = 11, Qty = 50, CreatedDate = DateTime.Now }
        };
        public static List<Book> BookList => bookList;
    }
}
