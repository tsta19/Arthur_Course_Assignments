using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using CarCRUD.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using CarCRUD.DbContexts;

namespace CarCRUD.Repositories
{
    public class PartRepository
    {
        private CarPartsDbContext _context;
        public PartRepository(CarPartsDbContext context) 
        {
            _context = context;
        }
        public CarPart Get(int id)
        {
            var carPart = _context.CarParts.Where(a => a.Id == id).First();
            return carPart;
        }
        public List<CarPart> List(int Limit = 5)
        {
            return _context.CarParts.ToList();
        }
        public void Create(CarPart carPart)
        {
            _context.Add(carPart);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            _context.Remove(_context.CarParts.Single(a => a.Id == id));
            _context.SaveChanges();
        }
        public void Update(int id, CarPart carPart)
        {
            var carPartOld = _context.CarParts.First(a => a.Id == id);
            carPartOld.Name = carPart.Name;
            carPartOld.Price = carPart.Price;
            carPartOld.Details = carPart.Details;
            _context.SaveChanges();
        }
        public CarPart FillPart(SqlDataReader result)
        {
            var CarPart = new CarPart();
            CarPart.Id = (int)result.GetValue(0);
            CarPart.Name = (string)result.GetValue(1);
            CarPart.Price = (double)result.GetValue(2);
            CarPart.Details = (string)result.GetValue(3);
            return CarPart;
        }
    }
}
