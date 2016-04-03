﻿using CsomInspector.Core;
using System.Collections.Generic;
using System.Linq;
using Action = CsomInspector.Core.Actions.Action;

namespace CsomInspector.Fiddler.Presentation
{
	public class RequestViewModel : ViewModelBase
	{
		public RequestViewModel()
		{
		}

		private IEnumerable<Action> _actions;
		private IEnumerable<Result> _results;
		private Action _selectedAction;

		public IEnumerable<Action> Actions
		{
			get
			{
				return _actions;
			}
			set
			{
				_actions = value;
				RaisePropertyChanged(nameof(Actions));
				SelectedAction = _actions.FirstOrDefault();
			}
		}

		public IEnumerable<Result> Results
		{
			get
			{
				return _results;
			}
			set
			{
				_results = value;
				RaisePropertyChanged(nameof(Result));
				RaisePropertyChanged(nameof(SelectedResult));
			}
		}

		public Action SelectedAction
		{
			get
			{
				return _selectedAction;
			}
			set
			{
				_selectedAction = value;
				RaisePropertyChanged(nameof(SelectedAction));
				RaisePropertyChanged(nameof(SelectedResult));
			}
		}

		public Result SelectedResult
		{
			get
			{
				if (SelectedAction != null)
				{
					return Results
						.Where(r => r.ActionId == SelectedAction.Id)
						.FirstOrDefault();
				}

				return null;
			}
		}
	}
}