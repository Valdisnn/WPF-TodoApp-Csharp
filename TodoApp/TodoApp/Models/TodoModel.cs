using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models {
  class TodoModel: INotifyPropertyChanged {
    // Дата создания
    public DateTime CreationDate {
      get;
      set;
    } = DateTime.Now;

    // Состояние задачи
    private bool _isDone;

    public bool IsDone {
      get {
        return _isDone;
      }
      set {
        if (_isDone == value) return;
        _isDone = value;
        OnPropertyChanged("IsDone");
      }
    }

    // Текст задачи
    private string _text;

    public string Text {
      get {
        return _text;
      }
      set {
        if (_text == value) return;
        _text = value;
        OnPropertyChanged("Text");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName = "") {
      // более простой вариант через обычное условие
      /*if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
            */

      // проверка с помощью тернарного оператора
      PropertyChanged ? .Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}