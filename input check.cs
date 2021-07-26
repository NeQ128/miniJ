using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniJ
{
    class input_check
    {
        bool first_b;
        bool second_b;
        int first_num;
        int second_num;
        public int input_word(string e)
        {
            int num = -1;
            if (!first_b)
                num = check_first(e);
            else if (!second_b)
                num = check_second(e);
            else
                num = check_third(e);
            return num;
        }

        private int check_first(string e)
        {
            switch (e)
            {
                case "C":
                    first_num = 1;
                    first_b = true;
                    break;
                case "K":
                    first_num = 1;
                    first_b = true;
                    break;
                case "S":
                    first_num = 2;
                    first_b = true;
                    break;
                case "T":
                    first_num = 3;
                    first_b = true;
                    break;
                case "N":
                    first_num = 4;
                    first_b = true;
                    break;
                case "H":
                    first_num = 5;
                    first_b = true;
                    break;
                case "F":
                    first_num = 6;
                    first_b = true;
                    break;
                case "M":
                    first_num = 7;
                    first_b = true;
                    break;
                case "Y":
                    first_num = 8;
                    first_b = true;
                    break;
                case "R":
                    first_num = 9;
                    first_b = true;
                    break;
                case "W":
                    first_num = 10;
                    first_b = true;
                    break;
                case "A":
                    return 1;
                case "I":
                    return 2;
                case "U":
                    return 3;
                case "E":
                    return 4;
                case "O":
                    return 5;
                default:
                    return -1;
            }
            return -1;
        }

        private int check_second(string e)
        {
            switch (e)
            {
                case "A":
                    switch (first_num)
                    {
                        case 1:
                            first_b = false;
                            return 6;
                        case 2:
                            first_b = false;
                            return 11;
                        case 3:
                            first_b = false;
                            return 16;
                        case 4:
                            first_b = false;
                            return 21;
                        case 5:
                            first_b = false;
                            return 26;
                        case 7:
                            first_b = false;
                            return 31;
                        case 8:
                            first_b = false;
                            return 36;
                        case 9:
                            first_b = false;
                            return 39;
                        case 10:
                            first_b = false;
                            return 44;
                        default:
                            break;
                    }
                    break;
                case "I":
                    switch (first_num)
                    {
                        case 1:
                            first_b = false;
                            return 7;
                        case 2:
                            first_b = false;
                            return 12;
                        case 3:
                            first_b = false;
                            return 17;
                        case 4:
                            first_b = false;
                            return 22;
                        case 5:
                            first_b = false;
                            return 27;
                        case 7:
                            first_b = false;
                            return 32;
                        case 9:
                            first_b = false;
                            return 40;
                        default:
                            break;
                    }
                    break;
                case "U":
                    switch (first_num)
                    {
                        case 1:
                            first_b = false;
                            return 8;
                        case 2:
                            first_b = false;
                            return 13;
                        case 3:
                            first_b = false;
                            return 18;
                        case 4:
                            first_b = false;
                            return 23;
                        case 5:
                            first_b = false;
                            return 28;
                        case 6:
                            first_b = false;
                            return 28;
                        case 7:
                            first_b = false;
                            return 33;
                        case 8:
                            first_b = false;
                            return 37;
                        case 9:
                            first_b = false;
                            return 41;
                        default:
                            break;
                    }
                    break;
                case "E":
                    switch (first_num)
                    {
                        case 1:
                            first_b = false;
                            return 9;
                        case 2:
                            first_b = false;
                            return 14;
                        case 3:
                            first_b = false;
                            return 19;
                        case 4:
                            first_b = false;
                            return 24;
                        case 5:
                            first_b = false;
                            return 29;
                        case 7:
                            first_b = false;
                            return 34;
                        case 9:
                            first_b = false;
                            return 42;
                        default:
                            break;
                    }
                    break;
                case "O":
                    switch (first_num)
                    {
                        case 1:
                            first_b = false;
                            return 10;
                        case 2:
                            first_b = false;
                            return 15;
                        case 3:
                            first_b = false;
                            return 20;
                        case 4:
                            first_b = false;
                            return 25;
                        case 5:
                            first_b = false;
                            return 30;
                        case 7:
                            first_b = false;
                            return 35;
                        case 8:
                            first_b = false;
                            return 38;
                        case 9:
                            first_b = false;
                            return 43;
                        case 10:
                            first_b = false;
                            return 45;
                        default:
                            break;
                    }
                    break;
                case "H":
                    switch (first_num)
                    {
                        case 1:
                            second_b = true;
                            second_num = 1;
                            break;
                        case 2:
                            second_b = true;
                            second_num = 2;
                            break;
                        default:
                            break;
                    }
                    break;
                case "S":
                    if(first_num == 3)
                    {
                        second_b = true;
                        second_num = 3;
                    }
                    break;
                case "N":
                    if (first_num == 4)
                    {
                        first_b = false;
                        return 0;
                    }
                    break;
                default:
                    check_first(e);
                    break;
            }
            return -1;
        }

        private int check_third(string e)
        {
            switch (e)
            {
                case "U":
                    if (first_num == 3 && second_num == 3)
                    {
                        first_b = false;
                        second_b = false;
                        return 18;
                    }
                    break;
                case "I":
                    if (first_num == 1 && second_num == 1)
                    {
                        first_b = false;
                        second_b = false;
                        return 17;
                    }
                    if (first_num == 2 && second_num == 2)
                    {
                        first_b = false;
                        second_b = false;
                        return 12;
                    }
                    break;
                default:
                    first_b = false;
                    first_num = 0;
                    second_b = false;
                    second_num = 0;
                    break;
            }
            return -1;
        }
    }
}
