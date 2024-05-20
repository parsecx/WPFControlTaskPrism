using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFControlTaskPrism.ViewModels
{
    public partial class HomeViewViewModel : BindableBase
    {
        private DelegateCommand _addClicked;
        public DelegateCommand AddClickedCommand =>
            _addClicked ?? (_addClicked = new DelegateCommand(ExecuteAddClickedCommand));

        private DelegateCommand _undoClicked;
        public DelegateCommand UndoClickedCommand =>
            _undoClicked ?? (_undoClicked = new DelegateCommand(ExecuteUndoClickedCommand));

        private DelegateCommand _refreshClicked;
        public DelegateCommand RefreshClickedCommand =>
            _refreshClicked ?? (_refreshClicked = new DelegateCommand(ExecuteRefreshClickedCommand));

        private DelegateCommand _deleteClicked;
        public DelegateCommand DeleteClickedCommand =>
            _deleteClicked ?? (_deleteClicked = new DelegateCommand(ExecuteDeleteClickedCommand));

        private DelegateCommand _editClicked;
        public DelegateCommand EditClickedCommand =>
            _editClicked ?? (_editClicked = new DelegateCommand(ExecuteEditClickedCommand));

        private DelegateCommand _saveClicked;
        public DelegateCommand SaveClickedCommand =>
            _saveClicked ?? (_saveClicked = new DelegateCommand(ExecuteSaveClickedCommand));

        private DelegateCommand _searchClicked;
        public DelegateCommand SearchClickedCommand =>
            _searchClicked ?? (_searchClicked = new DelegateCommand(ExecuteSearchClickedCommand));

        void ExecuteSearchClickedCommand()
        {

        }

        void ExecuteSaveClickedCommand()
        {

        }

        void ExecuteEditClickedCommand()
        {

        }

        void ExecuteDeleteClickedCommand()
        {

        }

        void ExecuteRefreshClickedCommand()
        {

        }

        void ExecuteUndoClickedCommand()
        {

        }

        void ExecuteAddClickedCommand()
        {

        }

        public HomeViewViewModel()
        {
            
        }
    }
}
