using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class ToDoListValidation : AbstractValidator<ToDoList>
    {
        public ToDoListValidation()
        {
            RuleFor(x=>x.TodoListTitle).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.TodoListTitle).MaximumLength(100).WithMessage("Maksimum karakter sınırı 100");
            RuleFor(x=>x.TodoListTitle).MinimumLength(1).WithMessage("Minimum karakter sınırı 1");
        }
    }
}
