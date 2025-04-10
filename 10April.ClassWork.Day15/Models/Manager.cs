using _10April.ClassWork.Day15.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10April.ClassWork.Day15.Models
{
    public class Manager<T> where T : BaseEntity
    {
        List<T> Items = [];
        public void Add(T entity)
        {

            var isExist = Items.Any(x => x.Id == entity.Id);

            if (isExist)
                throw new RepeatedIdException("This item has already exist");

            Items.Add(entity);
            Console.WriteLine();
        }

        public void Remove(int id)
        {
            var entity = Items.Find(x => x.Id == id);
            if (entity is null)
                throw new WrongIdException("Item is not found!");
            Items.Remove(entity);
        }

        public void Update(T entity)
        {
           
        }

        public void GetById(int id)
        {
            var item = Items.Find(x => x.Id == id);
            if (item is null)
                throw new WrongIdException("Item is not found!");
        }

        public void GetAll()
        {
            foreach (var item in Items)
                Console.WriteLine(item);
        }
    }
}
