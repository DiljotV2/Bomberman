using System;
using System.Security.Cryptography;
using System.Text;
using Bomberman;
using SplashKitSDK;

public class Program
{

    public static void Main()
    {
        int _delay = 5;

        Resources LoadResources = new Resources();// need to delete 

        LoadResources.Load_images();// need to del

        Player Bomberman = new Player();

        Terrain level1 = new Terrain(Bomberman);
        level1.Loadmap("Terrains/Terrain1.txt");

        new Window("Bomberman", 800, 550);
        do
        {
            SplashKit.ProcessEvents();
        
            _delay--;
            if (_delay == 0)
            {
                _delay = 30;
                level1.E1.Random_Movement(level1);
                level1.E2.Random_Movement(level1);
                level1.E3.Random_Movement(level1);
                level1.E4.Random_Movement(level1);
            }

            Bomberman.Update(level1);
            level1.ResetCoords();
            level1.Draw_Map();
            Bomberman.Cooldown();
     
            SplashKit.RefreshScreen(30);
        } while (!SplashKit.WindowCloseRequested("Bomberman"));
    }
}
