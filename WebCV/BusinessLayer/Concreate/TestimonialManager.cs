using BusinessLayer.Abstract;
using DataAccessLayer.Entity;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class TestimonialManager:ITestimonialService
    {
        EFTestimonialDAL _testimonial;

        public TestimonialManager(EFTestimonialDAL testimonial)
        {
            _testimonial = testimonial;
        }

        public List<Testimonial> TGetAllPasif()
        {
            return _testimonial.GetAll(x => x.TestimonialStatus == false);
        }

        public void TAdd(Testimonial t)
        {
            _testimonial.Add(t);
        }

        public List<Testimonial> TGetAll()
        {
            return _testimonial.GetAll(x=>x.TestimonialStatus==true);   
        }

        public List<Testimonial> TGetAllCount(int listCount)
        {
            return _testimonial.GetAllCount(listCount);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonial.GetByID(id);
        }

        public void TRemove(Testimonial t)
        {
            _testimonial.Remove(t);
        }

        public void TUppdate(Testimonial t)
        {
            _testimonial.Uppdate(t);
        }
    }
}
