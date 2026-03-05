using System;
using Newton.json;

public class Class1
{
	public Class1()
	{


         public string connectionstring = "datasource=inventory/inventory;database=inventory; uid=inv123;pwd=#1648inv";

        public dataset ds;
        public inventory_admim(string user_id)
        {
         new sqlconnection= sqlconnection(connectionstring);
        
                using (sqlconnection)
                {
                    cmd.conopen();
                    cmd.addparameter(user_id);
                    cmd.addparameter("i");
                    cmd.procedure(sp_inventory);
                     cmd.exec();
                    cmd.append(ds);
                     cmd.close();
                }

            return converttojson(ds);

        }

    public inventory_user(string user_id)
    {
        new sqlconnection= sqlconnection(connectionstring);

        using (sqlconnection)
        {
            cmd.conopen();
            cmd.addparameter(user_id);
            cmd.addparameter("U");
            cmd.procedure(sp_inventory);
            cmd.exec();
            cmd.append(ds);
            cmd.close();
        }

        return converttojson(ds);

    }

    public inventory_invwait(string user_id)
    {
        new sqlconnection= sqlconnection(connectionstring);

        using (sqlconnection)
        {
            cmd.conopen();
            cmd.addparameter(user_id);
            cmd.addparameter("R");
            cmd.procedure(sp_inventory);
            cmd.exec();
            cmd.append(ds);
            cmd.close();
        }

        return converttojson(ds);

    }
}
}
