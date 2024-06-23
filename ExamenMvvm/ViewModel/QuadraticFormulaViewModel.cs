using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace Examen_Mvvm.ViewModels
{
    public partial class QuadraticFormulaViewModel : ObservableObject
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

        [RelayCommand]
        private void Calculate()
        {
            try { 
            // Validar que el valor de "a" no sea igual a 0
            if (A == 0)
            {
                throw new Exception("El valor de 'a' no puede ser igual a 0.");
            }

            // Calcular el discriminante (b^2 - 4ac)
            double discriminant = (B * B) - (4 * A * C);

            // Validar que el discriminante no sea negativo
           /* if (discriminant < 0)
            {
                throw new Exception("El discriminante no puede ser negativo.");
            }*/

            // Calcular las soluciones
            X1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
                X2 = (-B - Math.Sqrt(discriminant)) / (2 * A);


            }
            catch (Exception ex)
            {
                // Manejar la excepción y mostrar un mensaje de error
                //throw new Exception($"Error: {ex.Message}");

            }
        }

        [RelayCommand]
        private void Clear()
        {
            A = 0;
            B = 0;
            C = 0;
            X1 = 0;
            X2 = 0;
        }
    }
}
