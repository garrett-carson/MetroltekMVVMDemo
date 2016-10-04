namespace MetroltekMVVMDemo
{
    using Caliburn.Micro;
    using System;
    using System.Threading.Tasks;

    public class MainViewModel : PropertyChangedBase
    {
        private int _count;

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                NotifyOfPropertyChange(() => Count);
            }
        }

        public async void Click()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            Count++;
        }
    }
}