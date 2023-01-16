using ETicaretAPI.Application.ViewModels;
using FluentValidation;


namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator  : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen ürün adını boş geçmeyiniz")
                .MaximumLength(150)
                .MinimumLength(2)
                    .WithMessage("Lütfen ürün adını 2 ile 150 karakter arasında giriniz");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotEmpty()
                    .WithMessage("Lütfen stock bilgisini boş geçmeyiniz")
                .Must(s => s >= 0)
                    .WithMessage("Stock bilgisini 0 veya üstünde giriniz");


            RuleFor(p => p.Price)
               .NotEmpty()
               .NotEmpty()
                   .WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz")
               .Must(s => s >= 0)
                   .WithMessage("Fiyat bilgisi 0 veya negatif olamaz");

        }
    }
}
