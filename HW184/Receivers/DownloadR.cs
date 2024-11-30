using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HW184.Interfaces;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace HW184.Receivers
{
    internal class DownloadVideo : Ireceiver
    {
        string _url;
        public DownloadVideo(string url)
        {
            _url = url;
        }
        public async Task Operation()
        {
            Console.WriteLine("Ввведите путь для сохранения видеоролика");
            string path = Console.ReadLine();
            Console.WriteLine("Скачивание начинается");

            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(_url);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            if (streamInfo != null)
            {
                var fileName = $"{video.Title}.{streamInfo.Container}";
                var filePath = Path.Combine(path, fileName);

                await youtube.Videos.Streams.DownloadAsync(streamInfo, filePath);
            }
        }
    }
}