using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace Examen_Mvvm.ViewModels
{
    public partial class CuadraticaFormViewModel : ObservableObject
    {
        [ObservableProperty]
        private double a;

        [ObservableProperty]
        private double b;

        [ObservableProperty]
        private double c;

        [ObservableProperty]
        private double x1;

        [ObservableProperty]
        private double x2;

        [ObservableProperty]
        private double d;

        [ObservableProperty]
        private double r;


        [RelayCommand]
        private void Calcular()
        {
            D = B * B - 4 * A * C;

            if (D > 0 && A > 0)
            {
                R = Math.Sqrt(D);
                X1 = (-B + R) / (2 * A);
                X2 = (-B - R) / (2 * A);

            }
            else
             { 
                if (A == 0)
                {
                    X1 = 0;
                    X2 = 0;
                    MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROR", "Valor A es igual a cero, Cuadrática no tiene solución", "Aceptar"));
                }
                else
                {
                    X1 = 0;
                    X2 = 0;
                    MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROR", "Discriminante es negatico, Cuadrática no tiene solución", "Aceptar"));
                }
            }
           }


        [RelayCommand]

        public void Limpiar()
        {
            A = 0;
            B = 0;
            C = 0;
            D = 0;
            R = 0;
            X1 = 0;
            X2 = 0;

        }
        
    }
}
