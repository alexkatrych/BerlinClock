using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
  public class NumberSplitToLinesConverter : IIntToLinesConverter
  {
    private IIntToLinesConverter _highConverter;
    private IIntToLinesConverter _lowConverter;
    private INumberSplitter _splitter;

    public NumberSplitToLinesConverter(INumberSplitter splitter, 
      IIntToLinesConverter highConverter, 
      IIntToLinesConverter lowConverter )
    {
      _splitter = splitter;
      _highConverter = highConverter;
      _lowConverter = lowConverter;
    }

    public List<string> Convert(int input)
    {
      var result = new List<string>();

      var splitNumber = _splitter.Split(input);
      result.AddRange(_highConverter.Convert(splitNumber.Higher));
      result.AddRange(_lowConverter.Convert(splitNumber.Lower));

      return result;
    }
  }
}
