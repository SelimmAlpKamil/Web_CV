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
    public class PortfolioManager:IPortfolioService
    {
        EFPortfolioDAL _portfolio;

        public PortfolioManager(EFPortfolioDAL portfolio)
        {
            _portfolio = portfolio;
        }

        public void TAdd(Portfolio t)
        {
            _portfolio.Add(t);
        }

        public List<Portfolio> TGetAll()
        {
            return _portfolio.GetAll();
        }

        public List<Portfolio> TGetAllCount(int listCount)
        {
            return _portfolio.GetAllCount(listCount);
        }

        public Portfolio TGetByID(int id)
        {
            return _portfolio.GetByID(id);
        }

        public void TRemove(Portfolio t)
        {
            _portfolio.Remove(t);
        }

        public void TUppdate(Portfolio t)
        {
            _portfolio.Uppdate(t);
        }
    }
}
