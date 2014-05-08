using DesignPattern.Core.Facade.FamilyCinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Facade
{
    public class FamilyCinemaFacade
    {
        public Amplifier Amp { get; set; }

        public Tuner Tuner { get; set; }

        public DVDPlayer DVD { get; set; }

        public CDPlayer CD { get; set; }

        public Projector Projector { get; set; }

        public TheaterLights Lights { get; set; }

        public Screen Screen { get; set; }

        public PopcornPopper Popper { get; set; }

        public FamilyCinemaFacade(Amplifier amp, Tuner tuner, DVDPlayer dvd, CDPlayer cd, Projector projector, TheaterLights lights, Screen screen, PopcornPopper popper)
        {
            this.Amp = amp;
            this.Tuner = tuner;
            this.DVD = dvd;
            this.CD = cd;
            this.Projector = projector;
            this.Lights = lights;
            this.Screen = screen;
            this.Popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get Ready to watch a movie...");
            Popper.On();
            Popper.Pop();
            Lights.Dim();
            Screen.Down();
            Projector.On();
            Projector.WideScreenModel();
            Amp.On();
            Amp.SetSurroundSound();
            Amp.SetVolume();
            DVD.On();
            DVD.Play();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            Popper.Off();
            Lights.On();
            Screen.Up();
            Projector.Off();
            Amp.Off();
            DVD.Stop();
            DVD.Eject();
            DVD.Off();
        }
    }
}
