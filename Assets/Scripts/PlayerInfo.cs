

public class PlayerInfo 
{
   // storing player mood 
    private static float playerMood;
    
    public static float PlayerMood
    {
        get
        {
            return playerMood;

        }
        set 
        {
            playerMood = value;
        }
    }
    // storing player choices
   private static int dadConv1Choice1, dadConv1Choice2, dadConv1Choice3, momConv1Choice1, momConv1Choice2, neighbourConv1Choice1, neighbourConv1Choice2;
   public static int DadConv1Choice1
   {
       get
       {
           return dadConv1Choice1;
       }
       
       set 
       {
           dadConv1Choice1 = value;
       }
    }
   public static int DadConv1Choice2
   {
       get
       {
           return dadConv1Choice2;
       }
       set
       {
           dadConv1Choice2 = value;
       }
   }
     
   public static int DadConv1Choice3
   {
       get
       {
           return dadConv1Choice3;
       }
       set
       {
           dadConv1Choice3 = value;
       }
   }
   
   public static int MomConv1Choice1
   {
       get
       {
           return momConv1Choice1;
       }
       set
       {
           momConv1Choice1 = value;
       }
   }
   
   public static int MomConv1Choice2
   {
       get
       {
           return momConv1Choice2;
       }
       set
       {
           momConv1Choice2 = value;
       }
   }
  
   public static int NeighbourConv1Choice1
   {    
       get
       {
           return neighbourConv1Choice1;
       }
       set
       {
           neighbourConv1Choice1 = value;
       }
   }
   
   public static int NeighbourConv1Choice2
   {
       get
       {
           return neighbourConv1Choice2;
       }
       set
       {
           neighbourConv1Choice2 = value;
       }
   }
   private static string playerPhoto1, playerPhoto2, playerPhoto3, playerPhoto4, playerPhoto5, playerPhoto6;
   public static string PlayerPhoto1
   {
       get
       {
           return playerPhoto1;
       }
       set
       {
           playerPhoto1 = value;
       }
   }
   public static string PlayerPhoto2
   {
       get
       {
           return playerPhoto2;
       }
       set
       {
           playerPhoto2 = value;
       }
   }
   public static string PlayerPhoto3
   {
       get
       {
           return playerPhoto3;
       }
       set
       {
           playerPhoto3 = value;
       }
   }
   public static string PlayerPhoto4
   {
       get
       {
           return playerPhoto4;
       }
       set 
       {
           playerPhoto4 = value;
       }
   }
   public static string PlayerPhoto5
   {
       get 
       {
           return playerPhoto5;
       }
       set 
       {
           playerPhoto5 = value;
       }
   }
   public static string PlayerPhoto6
   {
       get 
       {
           return playerPhoto6;
       }
       set
       {
           playerPhoto6 = value;
       }
   }
}
