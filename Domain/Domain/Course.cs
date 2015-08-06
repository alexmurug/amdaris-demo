using System;
using System.Collections.Generic;
using Domain.Domain.Observer;

namespace Domain.Domain
{
    public class Course
    {
        private List<Book> _carti;
        private bool _current;

        public bool Current
        {
            get { return _current;}
            set
            {
                _current = value;
                Notify();
            }
        }
        private readonly string _nume;
        private DateTime _createtime;
        private readonly List<ISubscriber> _subscribers;

        public Course(List<Book> carti, bool current, string nume, DateTime createtime)
        {
            _carti = carti;
            _current = current;
            _nume = nume;
            _createtime = createtime;
            _subscribers = new List<ISubscriber>();
        }

        public string Nume
        {
            get { return _nume; }
        }


        public void Subscribe(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
            {
                _subscribers.Add(subscriber);
            }
        }

        public void UnSubscribe(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
            {
                _subscribers.Remove(subscriber);
            }
        }

        private void Notify()
        {
            foreach (var observer in _subscribers)
            {
                observer.Update(this);
            }
        }
    }
}