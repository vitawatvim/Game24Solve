using System;
using System.Data;
using Lists;

namespace GUImain
{
    public class Solver
    {
        public string[] solve(int[] num)
        {
            List solve = new ArrayList(10);
            int c = 0;
            int i = 0, j = 0, k = 0, l = 0;
            i = 0; j = 1; k = 2; l = 3;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 0; j = 1; k = 3; l = 2;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 0; j = 2; k = 3; l = 1;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 0; j = 2; k = 1; l = 3;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 0; j = 3; k = 1; l = 2;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 0; j = 3; k = 2; l = 1;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 1; j = 0; k = 2; l = 3;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 1; j = 0; k = 3; l = 2;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 1; j = 2; k = 0; l = 3;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 1; j = 2; k = 3; l = 0;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 1; j = 3; k = 0; l = 2;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 1; j = 3; k = 2; l = 0;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 2; j = 0; k = 1; l = 3;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 2; j = 0; k = 3; l = 1;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 2; j = 1; k = 0; l = 3;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {

                    solve.add(str);
                }
            }
            i = 2; j = 1; k = 3; l = 0;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 2; j = 3; k = 0; l = 1;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 2; j = 3; k = 1; l = 0;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 3; j = 0; k = 1; l = 2;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 3; j = 0; k = 2; l = 1;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 3; j = 1; k = 0; l = 2;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 3; j = 1; k = 2; l = 0;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 3; j = 2; k = 0; l = 1;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            i = 3; j = 2; k = 1; l = 0;
            foreach (string str in patern(i, j, k, l, num))
            {
                if (patern(i, j, k, l, num).Length != 0)
                {
                    solve.add(str);
                }
            }
            string[] answer = new string[solve.size()];
            for (int count = 0; count < solve.size(); count++)
            {

                if (solve.size() != 0)
                {
                    try
                    {
                        answer[count] = solve.get(count).ToString();
                    }
                    catch (NullReferenceException e) { Console.WriteLine(e); };
                }
            }
            return answer;
        }
        static double Evaluate(string expression)
        {
            var loDataTable = new DataTable();
            var loDataColumn = new DataColumn("Eval", typeof(double), expression);
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            return (double)(loDataTable.Rows[0]["Eval"]);
        }
        public string[] patern(int i, int j, int k, int l, int[] num)
        {
            List list = new ArrayList(1);
            string[] oper = { "+", "-", "*", "/" };
            for (int m = 0; m < oper.Length; m++)
            {
                for (int n = 0; n < oper.Length; n++)
                {
                    for (int o = 0; o < oper.Length; o++)
                    {
                        string str1 = "(" + num[i] + oper[m] + num[j] + ")" + oper[n] + "(" + num[k] + oper[o] + num[l] + ")";
                        string str2 = num[i] + oper[m] + "(" + num[j] + oper[n] + num[k] + ")" + oper[o] + num[l];
                        string str3 = "(" + num[i] + oper[m] + "(" + num[j] + oper[n] + num[k] + ")" + ")" + oper[o] + num[l];
                        string str4 = num[i] + oper[m] + "(" + "(" + num[j] + oper[n] + num[k] + ")" + oper[o] + num[l] + ")";
                        string str5 = "(" + "(" + num[i] + oper[m] + num[j] + ")" + oper[n] + num[k] + ")" + oper[o] + num[l];
                        string str6 = num[i] + oper[m] + "(" + num[j] + oper[n] + "(" + num[k] + oper[o] + num[l] + ")" + ")";
                        if (Evaluate(str1) == 24.0) { list.add(str1); }
                        if (Evaluate(str2) == 24.0) { list.add(str2); }
                        if (Evaluate(str3) == 24.0) { list.add(str3); }
                        if (Evaluate(str4) == 24.0) { list.add(str4); }
                        if (Evaluate(str5) == 24.0) { list.add(str5); }
                        if (Evaluate(str6) == 24.0) { list.add(str6); }
                    }
                }
            }
            string[] ans = { };
            if (list.size() != 0)
            {
                ans = new string[list.size()];
                for (int e = 0; e < list.size(); e++)
                {
                    ans[e] = list.get(e).ToString();
                }
            }
            return ans;
        }
    }
}

