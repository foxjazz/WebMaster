﻿using DogManager;

namespace myLib
{
    public class Testme
    {
        private IDogger _dog;
        public Testme(IDogger dogger) 
        {
            _dog = dogger;
        }
        public void doone(string data)
        {
            _dog.Info(data);
        }
    }
}