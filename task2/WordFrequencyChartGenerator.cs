using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace task2
{
    public class WordFrequencyChartGenerator
    {
        private readonly string[] _words;
        private readonly Dictionary<string, int> _chart;
        private readonly List<KeyValuePair<string,string>> _sortedDotChart;

        public WordFrequencyChartGenerator(string text)
        {
            _words = text.Split(' ');
            _chart = _words.GroupBy(word => word)
                .ToDictionary(word => word.Key, word => word.Count());
            _sortedDotChart = new List<KeyValuePair<string, string>>();
        }

        public IEnumerable<KeyValuePair<string,string>> GenerateChart(int maxDots)
        {
            int maxLength = _words.OrderByDescending(word => word.Length).First().Length;
            int maxFrequency = _chart.Values.Max();
            foreach (var pair in _chart.OrderBy(pair => pair.Value))
            {
                int numberOfDots = (int)Math.Round(((pair.Value * (double)maxDots) / maxFrequency));
                string newDictionaryKey = String.Concat(new String('_', maxLength - pair.Key.Length),pair.Key);
                _sortedDotChart.Add(new KeyValuePair<string, string>(newDictionaryKey, new String('.', numberOfDots)));
            }
            return _sortedDotChart;
        }
    }
}