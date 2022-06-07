using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProyectoFinal.Annotations;

namespace ProyectoFinal.Models
{
    public class IndivResult
    {
        private string __result;

        public string result
        {
            get { return __result; }
            set
            {
                __result = value; 
                OnPropertyChanged();
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        
        [NotifyPropertyChangedInvocator]
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}