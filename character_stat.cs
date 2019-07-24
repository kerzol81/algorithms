Dictionary<char, int> stat = new Dictionary<char, int>();

            foreach (string line in lines)
            {
                string cleaned = line.Replace(" ","");

                foreach (char letter in cleaned)
                {
                    if (stat.ContainsKey(letter))
                    {
                        stat[letter]++;
                    }
                    else
                    {
                        stat.Add(letter, 1);
                    }
                }
