using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleContentLibrary.TranslationServices;

public class FlexibleTranslationService : MainTranslationService
{
    private readonly IFlexibleDefaultTranslationService _flexible;
    public FlexibleTranslationService(IFlexibleDefaultTranslationService flexible)
    {
        _flexible = flexible;
    }
    public override string DefaultTranslationAbb => _flexible.DefaultTranslationAbb;
}
