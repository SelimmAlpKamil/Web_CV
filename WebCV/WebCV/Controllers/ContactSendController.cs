using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.Entity;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebCV.Controllers
{
    [AllowAnonymous]
    public class ContactSendController : Controller
    {
        ContactManager contactManager = new ContactManager(new EFContactDAL());

        [HttpPost]
        public IActionResult ContactSend(Contact p)
        {
            ContactSendValidation validation = new ContactSendValidation();

            var rule = validation.Validate(p);

           if(rule.IsValid)
            {
                p.ContactDate = Convert.ToDateTime(DateTime.Now);
                p.ContactStatus = true;
                contactManager.TAdd(p);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                
 
                foreach (var x in rule.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                    
                }

                TempData["ErrorMessages"] = rule.Errors.Select(x => x.ErrorMessage).ToList();


            }

            return RedirectToAction("Index", "Home");

        }
    }
}
