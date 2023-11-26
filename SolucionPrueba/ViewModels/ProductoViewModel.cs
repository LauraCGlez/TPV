using ReactiveUI;

namespace SolucionPrueba.ViewModels
{
    public class ProductoViewModel : ReactiveObject
    {
        private string _nombre;
        private decimal _precio;
        private string _icon;

        public string Nombre
        {
            get => _nombre;
            set => this.RaiseAndSetIfChanged(ref _nombre, value);
        }

        public decimal Precio
        {
            get => _precio;
            set => this.RaiseAndSetIfChanged(ref _precio, value);
        }

        public string Icon
        {
            get => _icon;
            set => this.RaiseAndSetIfChanged(ref _icon, value);
        }
    }
}