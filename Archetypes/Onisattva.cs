using System;
using BlueprintCore.Blueprints.Configurators.Classes;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Microsoft.Build.Utilities;

namespace OnisattvaMod.Archetypes
{
    internal class Onisattva
    {
        
        // New, stable GUIDs (generate once, keep forever)
        // Blueprint names (keys) — back these with LocalizedStrings later
        internal const string ArchetypeName = "OnisattvaArchetype";
        internal const string ArchetypeDisplayName = "OnisattvaArchetype.Name";
        internal const string ArchetypeDescription = "OnisattvaArchetype.Description";
        internal const string ArchetypeGuid = "5cb1dedd-c274-48ab-98d3-dc04ab07520f";

        internal const string HellfireQiName = "OnisattvaArchetype.HellfireQi.Name";
        internal const string HellfireQiDescription = "OnisattvaArchetype.HellfireQi.Description";
        internal const string HellfireQiGuid = "de2f0650-dfba-4298-918e-3a1209f32e5d";

        internal const string ElementalInsightName = "OnisattvaArchetype.ElementalInsight.Name";
        internal const string ElementalInsightDescription = "OnisattvaArchetype.ElementalInsight.Description";
        internal const string ElementalInsightGuid = "579a8ce3-2fc3-4fe9-9b88-7d35b5c5180d";

        internal const string ElementalBodhiName = "OnisattvaArchetype.ElementalBodhi.Name";
        internal const string ElementalBodhiDescription = "OnisattvaArchetype.ElementalBodhi.Description";
        internal const string ElementalBodhiGuid = "ac2c8899-8a81-40af-b10f-289593754094";

        internal const string ElementalEmbodimentName = "OnisattvaArchetype.ElementalEmbodiment.Name";
        internal const string ElementalEmbodimentDescription = "OnisattvaArchetype.ElementalEmbodiment.Description";
        internal const string ElementalEmbodimentGuid = "8c0575f6-b88f-4c00-b9b2-3f4a8a3611f5";

        internal const string ElementalSutrasName = "OnisattvaArchetype.ElementalSutras.Name";
        internal const string ElementalSutrasDescription = "OnisattvaArchetype.ElementalSutras.Description";
        internal const string ElementalSutrasGuid = "cfaf81a0-ffc3-4e41-9e3d-5ce4629af2ad";

        internal const string BeginnerSutrasName = "OnisattvaArchetype.BeginnerSutras.Name";
        internal const string BeginnerSutrasDescription = "OnisattvaArchetype.BeginnerSutras.Description";
        internal const string BeginnerSutrasGuid = "a923cadc-876b-4f26-9993-615f5325bcb4";

        internal const string AdeptSutrasName = "OnisattvaArchetype.AdeptSutras.Name";
        internal const string AdeptSutrasDescription = "OnisattvaArchetype.AdeptSutras.Description";
        internal const string AdeptSutrasGuid = "524e6d86-6a31-4b0e-9e89-2e7e1425238e";

        internal const string ExpertSutrasName = "OnisattvaArchetype.ExpertSutras.Name";
        internal const string ExpertSutrasDescription = "OnisattvaArchetype.ExpertSutras.Description";
        internal const string ExpertSutrasGuid = "8dc0e05a-7709-4947-9ca1-40d00e1ea5d9";

        internal const string MasterSutrasName = "OnisattvaArchetype.MasterSutras.Name";
        internal const string MasterSutrasDescription = "OnisattvaArchetype.MasterSutras.Description";
        internal const string MasterSutrasGuid = "ea6d480b-716d-478a-8c54-62b1c923c624";

        internal const string FirstElectricSutraName = "OnisattvaArchetype.FirstElectricSutra.Name";
        internal const string FirstElectricSutraDescription = "OnisattvaArchetype.FirstElectricSutra.Description";
        internal const string FirstElectricSutraGuid = "d410872a-2055-413c-88cf-8a6ce4874eea";

        internal const string SecondElectricSutraName = "OnisattvaArchetype.SecondElectricSutra.Name";
        internal const string SecondElectricSutraDescription = "OnisattvaArchetype.SecondElectricSutra.Description";
        internal const string SecondElectricSutraGuid = "8a88b744-ca9c-4ae0-8fc8-fe609e2696f9";

        internal const string ThirdElectricSutraName = "OnisattvaArchetype.ThirdElectricSutra.Name";
        internal const string ThirdElectricSutraDescription = "OnisattvaArchetype.ThirdElectricSutra.Description";
        internal const string ThirdElectricSutraGuid = "ecc6130e-1b94-4f1a-8c36-ac4cf698ac46";

        internal const string FirstFireSutraName = "OnisattvaArchetype.FirstFireSutra.Name";
        internal const string FirstFireSutraDescription = "OnisattvaArchetype.FirstFireSutra.Description";
        internal const string FirstFireSutraGuid = "c18ff18c-850c-40e9-8efa-c4bcd6b9e2d2";

        internal const string SecondFireSutraName = "OnisattvaArchetype.SecondFireSutra.Name";
        internal const string SecondFireSutraDescription = "OnisattvaArchetype.SecondFireSutra.Description";
        internal const string SecondFireSutraGuid = "ffe26fa9-f1d3-42c1-946f-417deea684d4";

        internal const string ThirdFireSutraName = "OnisattvaArchetype.ThirdFireSutra.Name";
        internal const string ThirdFireSutraDescription = "OnisattvaArchetype.ThirdFireSutra.Description";
        internal const string ThirdFireSutraGuid = "7b22b66d-e567-4391-9c41-4dc217bafc59";

        internal const string FirstIceSutraName = "OnisattvaArchetype.FirstIceSutra.Name";
        internal const string FirstIceSutraDescription = "OnisattvaArchetype.FirstIceSutra.Description";
        internal const string FirstIceSutraGuid = "11fa7895-a3af-4b17-aa61-e5e9a63b5751";

        internal const string SecondIceSutraName = "OnisattvaArchetype.SecondIceSutra.Name";
        internal const string SecondIceSutraDescription = "OnisattvaArchetype.SecondIceSutra.Description";
        internal const string SecondIceSutraGuid = "a722ab52-af01-4220-a7f7-84cc60f7abf4";

        internal const string ThirdIceSutraName = "OnisattvaArchetype.ThirdIceSutra.Name";
        internal const string ThirdIceSutraDescription = "OnisattvaArchetype.ThirdIceSutra.Description";
        internal const string ThirdIceSutraGuid = "68f56218-8fb7-4a9e-a764-21595200ac8f";

        internal const string FirstEarthSutraName = "OnisattvaArchetype.FirstEarthSutra.Name";
        internal const string FirstEarthSutraDescription = "OnisattvaArchetype.FirstEarthSutra.Description";
        internal const string FirstEarthSutraGuid = "68f56218-8fb7-4a9e-a764-21595200ac8f";

        internal const string SecondEarthSutraName = "OnisattvaArchetype.SecondEarthSutra.Name";
        internal const string SecondEarthSutraDescription = "OnisattvaArchetype.SecondEarthSutra.Description";
        internal const string SecondEarthSutraGuid = "60e43b37-4b92-4203-9bd4-2a32408097ba";

        internal const string ThirdEarthSutraName = "OnisattvaArchetype.ThirdEarthSutra.Name";
        internal const string ThirdEarthSutraDescription = "OnisattvaArchetype.ThirdEarthSutra.Description";
        internal const string ThirdEarthSutraGuid = "1596ca03-4364-4fe2-a841-22430ac72a74";

        internal const string FirstWaterSutraName = "OnisattvaArchetype.FirstWaterSutra.Name";
        internal const string FirstWaterSutraDescription = "OnisattvaArchetype.FirstWaterSutra.Description";
        internal const string FirstWaterSutraGuid = "b01e9074-91d7-481b-b52f-c8bb37c07415";

        internal const string SecondWaterSutraName = "OnisattvaArchetype.SecondWaterSutra.Name";
        internal const string SecondWaterSutraDescription = "OnisattvaArchetype.SecondWaterSutra.Description";
        internal const string SecondWaterSutraGuid = "02378de4-7606-4286-bc11-15591429e894";

        internal const string ThirdWaterSutraName = "OnisattvaArchetype.ThirdWaterSutra.Name";
        internal const string ThirdWaterSutraDescription = "OnisattvaArchetype.ThirdWaterSutra.Description";
        internal const string ThirdWaterSutraGuid = "44d35e4a-9ef5-46c6-8d2a-4dee955d31be";

        internal const string FirstWindSutraName = "OnisattvaArchetype.FirstWindSutra.Name";
        internal const string FirstWindSutraDescription = "OnisattvaArchetype.FirstWindSutra.Description";
        internal const string FirstWindSutraGuid = "95da6f76-673e-41fc-8b52-de1a0cc46b44";

        internal const string SecondWindSutraName = "OnisattvaArchetype.SecondWindSutra.Name";
        internal const string SecondWindSutraDescription = "OnisattvaArchetype.SecondWindSutra.Description";
        internal const string SecondWindSutraGuid = "dc03954a-de80-423f-a9cb-cafdac8901b8";

        internal const string ThirdWindSutraName = "OnisattvaArchetype.ThirdWindSutra.Name";
        internal const string ThirdWindSutraDescription = "OnisattvaArchetype.ThirdWindSutra.Description";
        internal const string ThirdWindSutraGuid = "1859fe01-41e4-4035-86bb-3377a6482e48";

        internal const string FirstShadowSutraName = "OnisattvaArchetype.FirstShadowSutra.Name";
        internal const string FirstShadowSutraDescription = "OnisattvaArchetype.FirstShadowSutra.Description";
        internal const string FirstShadowSutraGuid = "cb7f16c8-1830-433a-82af-b0d42534c7c8";

        internal const string SecondShadowSutraName = "OnisattvaArchetype.SecondShadowSutra.Name";
        internal const string SecondShadowSutraDescription = "OnisattvaArchetype.SecondShadowSutra.Description";
        internal const string SecondShadowSutraGuid = "31bcfc56-9024-4672-9d31-96ec912449dd";

        internal const string ThirdShadowSutraName = "OnisattvaArchetype.ThirdShadowSutra.Name";
        internal const string ThirdShadowSutraDescription = "OnisattvaArchetype.ThirdShadowSutra.Description";
        internal const string ThirdShadowSutraGuid = "e35d50a4-1572-4a56-8d92-4097c864b422";

        internal const string FirstLightSutraName = "OnisattvaArchetype.FirstLightSutra.Name";
        internal const string FirstLightSutraDescription = "OnisattvaArchetype.FirstLightSutra.Description";
        internal const string FirstLightSutraGuid = "6a218ebd-82d5-467f-af90-ab12c669ab0b";

        internal const string SecondLightSutraName = "OnisattvaArchetype.SecondLightSutra.Name";
        internal const string SecondLightSutraDescription = "OnisattvaArchetype.SecondLightSutra.Description";
        internal const string SecondLightSutraGuid = "70b34f42-5bd8-43b2-a74b-3eecf9dc95c8";

        internal const string ThirdLightSutraName = "OnisattvaArchetype.ThirdLightSutra.Name";
        internal const string ThirdLightSutraDescription = "OnisattvaArchetype.ThirdLightSutra.Description";
        internal const string ThirdLightSutraGuid = "2ad37a87-1175-4310-b055-2629e4f6b936";

        internal const string FirstAkashicSutraName = "OnisattvaArchetype.FirstAkashicSutra.Name";
        internal const string FirstAkashicSutraDescription = "OnisattvaArchetype.FirstAkashicSutra.Description";
        internal const string FirstAkashicSutraGuid = "cb92c141-0359-4be9-8ca9-96ff5b411a97";

        internal const string SecondAkashicSutraName = "OnisattvaArchetype.SecondAkashicSutra.Name";
        internal const string SecondAkashicSutraDescription = "OnisattvaArchetype.SecondAkashicSutra.Description";
        internal const string SecondAkashicSutraGuid = "655a7e8d-d40e-4e83-a44e-f3b8beae15b3";

        internal const string ThirdAkashicSutraName = "OnisattvaArchetype.ThirdAkashicSutra.Name";
        internal const string ThirdAkashicSutraDescription = "OnisattvaArchetype.ThirdAkashicSutra.Description";
        internal const string ThirdAkashicSutraGuid = "80b72abb-668f-4be8-a22b-4c3088c40186";

        internal const string FirstVisceralSutraName = "OnisattvaArchetype.FirstVisceralSutra.Name";
        internal const string FirstVisceralSutraDescription = "OnisattvaArchetype.FirstVisceralSutra.Description";
        internal const string FirstVisceralSutraGuid = "0d4801e6-da5d-4ea7-8551-a6d4004e8182";

        internal const string SecondVisceralSutraName = "OnisattvaArchetype.SecondVisceralSutra.Name";
        internal const string SecondVisceralSutraDescription = "OnisattvaArchetype.SecondVisceralSutra.Description";
        internal const string SecondVisceralSutraGuid = "c8694a5a-1a8b-491d-be80-56e3760fca97";

        internal const string ThirdVisceralSutraName = "OnisattvaArchetype.ThirdVisceralSutra.Name";
        internal const string ThirdVisceralSutraDescription = "OnisattvaArchetype.ThirdVisceralSutra.Description";
        internal const string ThirdVisceralSutraGuid = "7eee8d50-827f-40fd-aca0-96b12c1b70f8";

        internal const string FirstPhysicalSutraName = "OnisattvaArchetype.FirstPhysicalSutra.Name";
        internal const string FirstPhysicalSutraDescription = "OnisattvaArchetype.FirstPhysicalSutra.Description";
        internal const string FirstPhysicalSutraGuid = "4761e4c2-2760-4d0f-94da-bf2215cc0a48";

        internal const string SecondPhysicalSutraName = "OnisattvaArchetype.SecondPhysicalSutra.Name";
        internal const string SecondPhysicalSutraDescription = "OnisattvaArchetype.SecondPhysicalSutra.Description";
        internal const string SecondPhysicalSutraGuid = "dff1bde4-7267-40f8-968b-adbffa0d6602";

        internal const string ThirdPhysicalSutraName = "OnisattvaArchetype.ThirdPhysicalSutra.Name";
        internal const string ThirdPhysicalSutraDescription = "OnisattvaArchetype.ThirdPhysicalSutra.Description";
        internal const string ThirdPhysicalSutraGuid = "e5f3adb0-397c-4455-8d8a-533a6089fb58";

        internal const string SpaceSutraName = "OnisattvaArchetype.SpaceSutra.Name";
        internal const string SpaceSutraDescription = "OnisattvaArchetype.SpaceSutra.Description";
        internal const string SpaceSutraGuid = "9011e052-7dab-44aa-9b1b-6e87bb86d9a2";

        internal const string GravitySutraName = "OnisattvaArchetype.GravitySutra.Name";
        internal const string GravitySutraDescription = "OnisattvaArchetype.GravitySutra.Description";
        internal const string GravitySutraGuid = "073322e7-4336-4f29-9fd3-b47f5e02f3ae";

        internal const string NuclearSutraName = "OnisattvaArchetype.NuclearSutra.Name";
        internal const string NuclearSutraDescription = "OnisattvaArchetype.NuclearSutra.Description";
        internal const string NuclearSutraGuid = "20819fc2-0cd2-473f-bce6-1dbc5b24805a";

        internal const string PhysicsSutraName = "";
        internal const string PhysicsSutraDescription = "";
        internal const string PhysicsSutraGuid = "";


        internal static readonly LogWrapper Logger = LogWrapper.Get("OnisattvaMod.OnisattvaArchetype");


        internal static void Configure()
        {
            try
            {
                ConfigureEnabled();
            } 
            catch (Exception e)
            {
                Logger.Error("Failed to configure Onisattva", e);
            }
        }
        
        private static void ConfigureEnabled(){
            Logger.Info($"Configuring {ArchetypeName}");

            var archetype = ArchetypeConfigurator.New(ArchetypeName, ArchetypeGuid, CharacterClassRefs.KineticistClass)
                .SetLocalizedName(ArchetypeDisplayName).SetLocalizedDescription(ArchetypeDescription);

            archetype.AddToRemoveFeatures(1, FeatureRefs.Infusion.ToString())
                .AddToRemoveFeatures(3, FeatureRefs.Infusion.ToString());

        }

    }
}
