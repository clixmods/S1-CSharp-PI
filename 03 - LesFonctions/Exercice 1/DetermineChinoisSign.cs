using System;
using System.Collections;
class DetermineChinoisSign
{
     public static string Exec()
        {
            /*
            Rat	1900 ou toutes les années correspondant à un cycle de 12 ans : 1912, 1924, 1936, 1948, 1960, 1972, 1984, 1996, 2008, 2020, etc.
            Bœuf (ou Buffle)	1901, 1913, 1925, 1937, 1949, 1961, 1973, 1985, 1997, 2009, 2021, etc.
            Tigre	1902, 1914, 1926, 1938, 1950, 1962, 1974, 1986, 1998, 2010, 2022, etc.
            Lièvre (ou Chat ou Lapin)	1903, 1915, 1927, 1939, 1951, 1963, 1975, 1987, 1999, 2011, 2023, etc.
            Dragon	1904, 1916, 1928, 1940, 1952, 1964, 1976, 1988, 2000, 2012, 2024, etc.
            Serpent	1905, 1917, 1929, 1941, 1953, 1965, 1977, 1989, 2001, 2013, 2025, etc.
            Cheval	1906, 1918, 1930, 1942, 1954, 1966, 1978, 1990, 2002, 2014, 2026, etc.
            Chèvre (ou Bouc)	1907, 1919, 1931, 1943, 1955, 1967, 1979, 1991, 2003, 2015, 2027, etc.
            Singe	1908, 1920, 1932, 1944, 1956, 1968, 1980, 1992, 2004, 2016, 2028, etc.
            Coq	1909, 1921, 1933, 1945, 1957, 1969, 1981, 1993, 2005, 2017, 2029, etc.
            Chien	1910, 1922, 1934, 1946, 1958, 1970, 1982, 1994, 2006, 2018, 2030, etc.
            Cochon (ou Sanglier)

            */
            int userInt = int.Parse(Console.ReadLine());
            string[] SignName = { "Rat", "Bœuf" , "Tigre", "Lièvre", "Dragon" ,"Serpen" ,"Cheval" ,"Chèvre" ,"Singe" ,"Coq", "Chien" ,"Cochon"};
            int[] SignModulo = {
                1912 % 12,
                1913 % 12,
                1914 % 12,
                1915 % 12,
                1916 % 12,
                1917 % 12,
                1918 % 12,
                1919 % 12,
                1920 % 12,
                1921 % 12,
                1922 % 12,
                1923 % 12
            };
            int userModulo = userInt % 12;
            for(int i = 0; i < SignModulo.Length;i++)
            {
                if(userModulo == SignModulo[i])
                {
                    return "Le signe de l'user est "+SignName[i];
                }
            }
            return "fail";
        }
}