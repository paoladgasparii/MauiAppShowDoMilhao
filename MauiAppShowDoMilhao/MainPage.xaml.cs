﻿using MauiAppShowDoMilhao.Models;
using Plugin.Maui.Audio;

namespace MauiAppShowDoMilhao
{
    public partial class MainPage : ContentPage
    {
        double premio = 1000;
        int pergunta_count = 1;

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = App.getRandomPerguntaFacil();

            lbl_nivel.Text = "Fácil";
            lbl_premio.Text = premio.ToString("C");
            lbl_pergunta_numero.Text = pergunta_count.ToString();

            //Adiciona som
            //Stream track = FileSystem.OpenAppPackageFileAsync("abertura.mp3").Result;
            //AudioManager.Current.CreatePlayer(track).Play();

        }

        protected async override void OnAppearing()
        {
            alt0.IsVisible = false;
            alt1.IsVisible = false;
            alt2.IsVisible = false;
            alt3.IsVisible = false;

            int tempo = 500;

            await alt0.TranslateTo(-1000, 0, 10, Easing.CubicOut);
            await Task.Delay(tempo);
            alt0.IsVisible = true;
            await alt0.TranslateTo(0, 0, 350, Easing.CubicOut);




            await alt1.TranslateTo(-1000, 0, 10, Easing.CubicOut);
            await Task.Delay(tempo);
            alt1.IsVisible = true;
            await alt1.TranslateTo(0, 0, 350, Easing.CubicOut);




            await alt2.TranslateTo(-1000, 0, 10, Easing.CubicOut);
            await Task.Delay(tempo);
            alt2.IsVisible = true;
            await alt2.TranslateTo(0, 0, 350, Easing.CubicOut);




            await alt3.TranslateTo(-1000, 0, 10, Easing.CubicOut);
            await Task.Delay(tempo);
            alt3.IsVisible = true;
            await alt3.TranslateTo(0, 0, 350, Easing.CubicOut);
        }


        private async void toca_som()
        {
            string track = "";

            switch (pergunta_count)
            {
                case 1:
                    track = "1000.wav";
                    break;

                case 2:
                    track = "2000.wav";
                    break;

                case 3:
                    track = "3000.wav";
                    break;

                case 4:
                    track = "4000.wav";
                    break;

                case 5:
                    track = "5000.wav";
                    break;

                case 6:
                    track = "10000.wav";
                    break;

                case 7:
                    track = "20000.wav";
                    break;

                case 8:
                    track = "30000.wav";
                    break;

                case 9:
                    track = "40000.wav";
                    break;

                case 10:
                    track = "50000.wav";
                    break;
                case 11:
                    track = "100000b.wav";
                    break;

                case 12:
                    track = "200000.wav";
                    break;

                case 13:
                    track = "300000.wav";
                    break;

                case 14:
                    track = "400000.wav";
                    break;

                case 15:
                    track = "500000.wav";
                    break;

                case 16:
                    track = "1000000.wav";
                    break;

            }
            AudioManager.Current.CreatePlayer(
                FileSystem.OpenAppPackageFileAsync(track).Result).Play();
        }
        private async void Button_Clicked_Parar(object sender, EventArgs e)
        {
            premio = 0;
            pergunta_count = 1;
            avanca_pergunta();
        }

        private async void Button_Clicked_Proxima(object sender, EventArgs e)
        {
                bool acertou = false;
                string resp = "";
                bool valor;

                if (alt0.IsChecked)
                {
                    if ((bool)alt0.Value)
                    {
                        acertou = true;
                        resp = alt0.Content.ToString();
                    }
                }

                if (alt1.IsChecked)
                {
                    if ((bool)alt1.Value)
                    {
                        acertou = true;
                        resp = alt1.Content.ToString();
                    }
                }

                if (alt2.IsChecked)
                {
                    if ((bool)alt2.Value)
                    {
                        acertou = true;
                        resp = alt2.Content.ToString();
                    }
                }

                if (alt3.IsChecked)
                {
                    if ((bool)alt3.Value)
                    {
                        acertou = true;
                        resp = alt3.Content.ToString();
                    }
                }

                if (acertou)
                {
                    Stream track = FileSystem.OpenAppPackageFileAsync("parabens.wav").Result;
                    AudioManager.Current.CreatePlayer(track).Play();

                    await DisplayAlert("ACERTOU!", resp, "OK");
                    pergunta_count++;
                    toca_som();
                    avanca_pergunta();
                    this.OnAppearing();
                }
                else
                {
                    Stream track = FileSystem.OpenAppPackageFileAsync("errou.wav").Result;
                    AudioManager.Current.CreatePlayer(track).Play();

                    await DisplayAlert("ERROU!", "Você perdeu", "OK");
                    premio = 0;
                    pergunta_count = 1;
                    toca_som();
                    avanca_pergunta();

                }
            }

            void avanca_pergunta()
            {
                if (pergunta_count <= 5)
                {
                    premio = premio + 1000;
                    this.BindingContext = App.getRandomPerguntaFacil();
                    lbl_nivel.Text = "Fácil";
                }

                if (pergunta_count == 6)
                {
                    premio = 10000;
                    this.BindingContext = App.getRandomPerguntaMedia();
                    lbl_nivel.Text = "Médio";
                }

                if (pergunta_count >= 7 && pergunta_count <= 10)
                {
                    premio = premio + 10000;
                    this.BindingContext = App.getRandomPerguntaMedia();
                    lbl_nivel.Text = "Médio";
                }

                if (pergunta_count == 11)
                {
                    premio = 100000;
                    this.BindingContext = App.getRandomPerguntaDificil();
                    lbl_nivel.Text = "Difícil";
                }

                if (pergunta_count >= 12 && pergunta_count <= 15)
                {
                    premio = premio + 100000;
                    this.BindingContext = App.getRandomPerguntaDificil();
                    lbl_nivel.Text = "Difícil";
                }
                if (pergunta_count == 16)
                {
                    premio = 1000000;
                    this.BindingContext = App.getRandomPerguntaFinal();
                    lbl_nivel.Text = "Final";
                }
                lbl_premio.Text = premio.ToString("C");
                lbl_pergunta_numero.Text = pergunta_count.ToString();
            }
        }
    }


