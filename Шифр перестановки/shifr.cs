﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Шифр_перестановки
{
    class shifr
    {
        private int[] key = null;

        public void SetKey(int[] _key)
        {
            key = new int[_key.Length];

            for (int i = 0; i < _key.Length; i++)
                key[i] = _key[i];
        }

        public void SetKey(string[] _key)
        {
            
            key = new int[_key.Length];

            for (int i = 0; i < _key.Length; i++)
                key[i] = Convert.ToInt32(_key[i]);
        }

        public void SetKey(string _key)
        {
            SetKey(_key.Split(' '));
        }

        public string Encrypt(string input)
        {
            for (int i = 0; i < input.Length % key.Length; i++)
                input += input[i];

            string result = "";

            for (int i = 0; i < input.Length; i += key.Length)
            {
                char[] shifr = new char[key.Length];

                for (int j = 0; j < key.Length; j++)
                    shifr[key[j] - 1] = input[i + j];

                for (int j = 0; j < key.Length; j++)
                    result += shifr[j];
            }

            return result;
        }

        public string Decrypt(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i += key.Length)
            {
                char[] shifr = new char[key.Length];

                for (int j = 0; j < key.Length; j++)
                    shifr[j] = input[i + key[j] - 1];

                for (int j = 0; j < key.Length; j++)
                    result += shifr[j];
            }

            return result;
        }
    }
}
