using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Reactive;
using DynamicData;

namespace SolucionPrueba.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _nombreEmpleado;
        private ObservableCollection<ProductoViewModel> _productos;
        private decimal _total;

        public MainWindowViewModel()
        {
            // Inicialización de propiedades y comandos
            NombreEmpleado = "Juan Pérez"; // Puedes cambiar esto según tu lógica de autenticación
            Productos = new ObservableCollection<ProductoViewModel>();
            Total = 0.0m;

            AgregarProductoCommand = ReactiveCommand.Create<ProductoViewModel>(AgregarProducto);
            
            InicializarProductos();
        }

        private void InicializarProductos()
        {
            Productos.Add(new ProductoViewModel {Nombre = "Producto1", Precio = 10.0m, Icon = "/Assets/producto1.png"});
            Productos.Add(new ProductoViewModel {Nombre = "Producto2", Precio = 4.0m, Icon = "/Assets/producto2.png"});
        }

        public string NombreEmpleado
        {
            get => _nombreEmpleado;
            set => this.RaiseAndSetIfChanged(ref _nombreEmpleado, value);
        }

        public ObservableCollection<ProductoViewModel> Productos
        {
            get => _productos;
            set => this.RaiseAndSetIfChanged(ref _productos, value);
        }

        public decimal Total
        {
            get => _total;
            set => this.RaiseAndSetIfChanged(ref _total, value);
        }

        public ReactiveCommand<ProductoViewModel, Unit> AgregarProductoCommand { get; }

        private void AgregarProducto(ProductoViewModel producto)
        {
            // Lógica para agregar el producto a la compra
            Productos.Add(producto);
            Total += producto.Precio;
        }
    }
}