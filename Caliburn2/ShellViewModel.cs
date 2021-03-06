﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Caliburn2
{
    [Export(typeof(IShell))]
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        //string name;

        //public string Name
        //{
        //    get { return name; }
        //    set
        //    {
        //        name = value;
        //        NotifyOfPropertyChange(() => Name);
        //        NotifyOfPropertyChange(() => CanSayHello);
        //    }
        //}

        //public bool CanSayHello
        //{
        //    get { return !string.IsNullOrWhiteSpace(Name); }
        //}

        //public void SayHello()
        //{
        //    MessageBox.Show(string.Format("Hello {0}!", Name)); //Don't do this in real life :)
        //}

        public BindableCollection<Model> Items { get; private set; }

        public ShellViewModel()
        {
            Items = new BindableCollection<Model>{
            new Model { Id = Guid.NewGuid() },
            new Model { Id = Guid.NewGuid() },
            new Model { Id = Guid.NewGuid() },
            new Model { Id = Guid.NewGuid() }
        };
        }

        public void Add()
        {
            Items.Add(new Model { Id = Guid.NewGuid() });
        }

        public void Remove(Model child)
        {
            Items.Remove(child);
        }
    }
}

