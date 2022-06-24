using OneBeyondHackathon.Logic.Dto;

namespace OneBeyondHackathon.Logic.Service
{
    internal class ImageService : IImageService
    {
        private readonly IList<string> _imageUrls = new List<string>
        {
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633810886493-U61RTUC36ER0S5955U90/lizandmolliesnakeandladders.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633810914042-1HQWG7JNMBVWVE003VPE/lizandmollieburnoutodometer.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633810964064-G8WKYN8UC2NB7FLRKZOV/lizandmolliedoingyourbest.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633897046575-9VADF9VCTH1OU4OKACNR/lizfosslienprogressnotlinear.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633810992055-W44KAOAOQR30NY6CLM8W/lizfosslienwhatsuccesslookslike.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633813755009-PX3BGXB1L41JTKYFMWDU/lizfosslienyoucanstillsucceed.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633897407046-HQMNAYBP55EEP7TDF6WZ/lizfosslienchange.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633897824887-YO0U7K2XQXOFWAPP6OSB/lizfosslienprocrastination.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633897692435-YNMEKGG3SIJ2011OZNRZ/lizfosslienhealthyconflict.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633811011748-E6NWZ0F4JLUV2QRQ8F30/minormistake.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633897278005-7VKH2MNR6TWLSQPV11TS/lizfosslienadulthoodkitchen.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633814297900-3HK5N1JPUSAFNM1GFE2E/lizfosslienremembertocheckin.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633811064336-7013AZG2IV6F7HPH3ELW/howadulthoodfeels.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633897478234-BIW2TULFTKVCGOU0QSM0/lizfosslienreframes.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633811413568-NAOSVUPI47YUHWUZ1HCB/amatterofperspective.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633811245733-RM9R6RPUGODMM0XFJKH6/virtualmeetingbingo.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633813002150-NEYG0P6GPZLLAMZJRBD3/lizfosslienmeasuringyourlife.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633814109033-A8ZYQG42JM2K8ADSK1LO/lizfosslienmakingprogress.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633898655397-K1Q9090KD0D90F4R7I1R/lizfossliengettingstarted.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633814048893-WJD3P7B836FCNSD0PSWI/imfine.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633897178877-M30VY78Y5F4ZCI7FEP5B/lizfossliengreenestgrass.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633813174732-UA056BXTTVPN992QQ4DU/lizfosslienwhatweseevswhatwedont.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633899973754-GTZQZ71SIVT6U4ABPYYW/lizfossliencareforyourself.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633814077420-FVLLNK4JUVICM5FI3GYS/lizfosslienpowerofbelonging.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633900055387-29XGXJBJ4D6TIBG73602/lizfossliengreatmanager.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633900198993-5EHHTEJZ3XWSV5TK5ECL/lizfosslienvulnerability.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633897109804-74YP9HFJN4TKBPQAGQZW/lizfosslienactofkindness.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633900134928-24NB8Q2ZOY4ELVNFR33J/lizfosslienintrovertwall.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633814029121-1KNV1GM5RORN0E4GGHLK/lizfossliensmallstepsbigchange.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633898920172-NO7RWUZGUYR4GFK0XJV0/lizfosslienquarantineevolution.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633899430288-FAGRBXJDIPOEL27N1Z0H/lizfosslienvent.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633814137027-R7KV8OTFVZECZAR6QBPA/lizfosslienwhatifitdoes.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633814185351-VY36RFNIYSO5ZEOQBPXR/lizfossliensmallsteps.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633899164432-240OBFLIQ9VDAQWG7YGH/lizfosslienpsychologicalsafety.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633901871019-6UGZZCB12B6BJQQA5C0Z/lizfosslienomg.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633901817250-AMS1USM1WBY39NO7PP8P/lizfosslienstressfulemail.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633901682748-AO72V0I7V5N46WMPUB4K/lizfosslienpeoplepleasing.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633901764583-7LE1XG8D95YGJSD8W1BL/lizfosslienteamwork.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633901617120-SEKG78TIZBMFMDVOKZQQ/lizfossliensuccessandfailure.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633901559558-N66188CT2G34NHE6ITNZ/lizfosslienwhatyoucancontrol.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633901428369-FO09C6GYO16N67M14EMT/lizfosslienwhatpeoplehear.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1650143863366-NDU3XSFIVTQZ67PNDUIS/LizFosslienPeoplePleasing.jpg",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633901495496-KDV9OG015RZO5XP3DEDT/lizfosslientypesoffeedback.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1650143983561-J844ARKI1CIXQWDVOIOQ/LizFosslienJourney.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1650143771915-6EM4N1Y3YQAOEQQ5WAD9/LizFosslienEndure.jpg",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1650144073097-E63AGH3D0SPH8541YM5D/LizFosslienWhoYouCanBe.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633811081592-WW9I8T4NG0ZLUOJME3GW/goodthingstaketime.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1650144156016-87546V8MXUA7LZYB29PK/LizFosslienMotivationVsConsistency.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1650143677541-TOU4CSELOFU1WA2S3TNF/LizFosslienPlan.png",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1650143483794-VXE2AYBY0RGWAFMF8G2W/LizFosslienPrivilege.jpg",
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1650143237183-7TRIQZY9CRWWYTW831NT/LizFosslien1.png"
        };

        public ImageDTO GetRandom()
        {
            var random = new Random();
            var randomUrl = random.Next(_imageUrls.Count);
            return new ImageDTO { Url = _imageUrls[randomUrl] };
        }
    }
}
