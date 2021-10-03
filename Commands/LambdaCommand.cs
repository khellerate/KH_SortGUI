using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KHSortGUI.Commands
{
	internal class LambdaCommand : Base.Command
	{
		private readonly Action<object> _Execute;
		private readonly Func<object, bool> _CanExecute;

		public LambdaCommand(Action<object> execute, Func<object, bool> canExecute = null)
		{
			_Execute = execute ?? throw new ArgumentNullException(nameof(execute));
			_CanExecute = canExecute;
		}

		public override bool CanExecute(object parameter)
		{
			return _CanExecute.Invoke(parameter);
		}

		public override void Execute(object parameter) => _Execute(parameter);
	}
}
