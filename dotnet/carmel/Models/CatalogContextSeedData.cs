using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carmel.Models
{
    public class CatalogContextSeedData
    {
        private CatalogContext context;

        public CatalogContextSeedData(CatalogContext context)
        {
            this.context = context;
        }

        public void CreateSeedData()
        {
            if (!context.Components.Any())
            {
                var sampleTag = "";

                sampleTag = "Autocomplete";
                var autocompleteComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "autocomplete" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "0ddb2e1d4ff26b988382c9150d4fc475" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "api", gist = "55999353554add4f866b26481f0ad555" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "customizing-templates", gist = "f4755c3c68dab68260647851ff9e52a0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "customizing-templates" } } },
                        new Sample() { Name = "events", gist = "625fc6a733b599fa9374d732ae5e696d" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "server-filtering", gist = "65f25b1fb2e07ec4e2749d21136650e7" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "server-filtering" } } },
                        new Sample() { Name = "virtualization", gist = "1abf5f5fbb4d3e1306385506bc676aff" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "virtualization" } } },
                        new Sample() { Name = "grouping", gist = "5da30e9c363cf37fe3e313476a65edb4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "grouping" } } },
                        new Sample() { Name = "value-binding", gist = "ba981cf9b774273a75bb6a4dedf21190" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "value-binding" } } },
                        new Sample() { Name = "highlighting", gist = "078dec4fe353ff9214ef6d5ee0e091a7" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "highlighting" } } },
                        new Sample() { Name = "with.bind", gist = "2fa190db778824c2b406b10c673ae9ae" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "with.bind" } } },
                    }
                };

                context.Components.Add(autocompleteComponent);
                context.Samples.AddRange(autocompleteComponent.Samples);

                sampleTag = "Barcode";
                var barcodeComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "barcode" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "1174a9720369bfc0204a284bfd0a74da" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "api", gist = "f6f6705d175859d98e50b01f79f9e630" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(barcodeComponent);
                context.Samples.AddRange(barcodeComponent.Samples);

                sampleTag = "Button";
                var buttonComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "button" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "d946474293a740bfb5e70a1cca701403" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "api", gist = "b58fb5966dcc631ca13ad21b652c3ecc" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "images", gist = "01f85d8286ecc18ede0332282b777571" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "images" } } },
                        new Sample() { Name = "events", gist = "1c8810a1a712adbf51e6edcfb1b3806c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "binding", gist = "18b9f8b2c2e4216abe16bc970f5077f1" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding" } } },
                    }
                };

                context.Components.Add(buttonComponent);
                context.Samples.AddRange(buttonComponent.Samples);

                sampleTag = "ButtonGroup";
                var buttongroupComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "buttongroup" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "98fc25811319a1ba6ba11e3cc04e1771" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                    }
                };

                context.Components.Add(buttongroupComponent);
                context.Samples.AddRange(buttongroupComponent.Samples);

                sampleTag = "Calendar";
                var calendarComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "calendar" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "b9634cd655ff5521b6637a2908027f67" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "api", gist = "9c78e8b3f530d6fd8f2827a25a9bdb17" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "disable-dates", gist = "bfd087bd282d634cc984f70bf04312e5" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "disable-dates" } } },
                        new Sample() { Name = "events", gist = "735494cb679f7352ae77a5e9ded4375f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "templates", gist = "0cb1748b00603ba2c33bd5314b11a7a6" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "templates" } } },
                    }
                };

                context.Components.Add(calendarComponent);
                context.Samples.AddRange(calendarComponent.Samples);

                sampleTag = "Area charts";
                var areachartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "areacharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "dfb0b040f119811487e936047282369e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "binding-to-grouped-data", gist = "8a0ec3066cf189f1e30c01bc648a73c0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-grouped-data" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "aa0aa36a64c549cf432255d841c60933" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "151e6287b1df61aa302519746a92bb0f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "date-axis", gist = "5cd0490a6405634e43c4f95ea13ce165" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "date-axis" } } },
                        new Sample() { Name = "error-bars", gist = "076f98864c4588c5e3859ce3fcd115b2" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "error-bars" } } },
                        new Sample() { Name = "logarithmic-axis", gist = "508b321c6aacfc95fa287c7931bb7e07" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "logarithmic-axis" } } },
                        new Sample() { Name = "multi-axis", gist = "f72e4b95b074d85274853197c7e1898b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "multi-axis" } } },
                        new Sample() { Name = "smooth-area", gist = "1b65dfcfb04044a183ae063525f39a32" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "smooth-area" } } },
                        new Sample() { Name = "stacked-area", gist = "f0063db0a4d61e41cfad859b969839a6" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "stacked-area" } } },
                        new Sample() { Name = "stepped-area", gist = "dcd11908a05d4e49279274511ff45e3f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "stepped-area" } } },
                    }
                };

                context.Components.Add(areachartsComponent);
                context.Samples.AddRange(areachartsComponent.Samples);

                sampleTag = "Bar charts";
                var barchartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "barcharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "8a044bd800cb0d778294b085072c0904" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "binding-to-grouped-data", gist = "dbf44e6d1e0e6bb49117301600217f11" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-grouped-data" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "343aa53be94df643f8d20e91b818585a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "dc9fce86e83eba3cfcc759190c8a9b31" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "column-chart", gist = "67047edae679fdd70d5efbc7cb02fd5d" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "column-chart" } } },
                        new Sample() { Name = "custom-pan-and-zoom", gist = "b92e5ae3f5f91347e94f4230a96c8be9" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "custom-pan-and-zoom" } } },
                        new Sample() { Name = "custom-visuals", gist = "3d03c29e13516179243ebeaa9daa2f2f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "custom-visuals" } } },
                        new Sample() { Name = "date-axis", gist = "dec064286e0713f2dc2db1c1e4ae52d7" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "date-axis" } } },
                        new Sample() { Name = "error-bars", gist = "063c85dba726bbc23be0c1528bf232af" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "error-bars" } } },
                        new Sample() { Name = "gap-and-spacing", gist = "bc417ef9d551bf85190efb8fd807f5ff" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "gap-and-spacing" } } },
                        new Sample() { Name = "logarithmic-axis", gist = "470c732c324e4a8a3e1b21d20b94df44" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "logarithmic-axis" } } },
                        new Sample() { Name = "multi-axis", gist = "3bbd4da640d51d95f058279b1a5ddc2f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "multi-axis" } } },
                        new Sample() { Name = "pan-and-zoom", gist = "0a9da57fbd615bc47a384f2b23f7e4cf" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "pan-and-zoom" } } },
                        new Sample() { Name = "plot-bands", gist = "54ecc895482858c0c385109a133355a9" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "plot-bands" } } },
                        new Sample() { Name = "stacked-and-grouped-bars-100", gist = "49586cc2e1cd918be7dde38625059b4b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "stacked-and-grouped-bars-100" } } },
                        new Sample() { Name = "stacked-and-grouped-bars", gist = "673d2e6b2a84cc11ad2f5b45d529773b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "stacked-and-grouped-bars" } } },
                        new Sample() { Name = "stacked-bars-100", gist = "7242609618eaf4417ce557ea7714269a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "stacked-bars-100" } } },
                        new Sample() { Name = "stacked-bars", gist = "b9157321b90e780376ed5d6008473bd7" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "stacked-bars" } } },
                    }
                };

                context.Components.Add(barchartsComponent);
                context.Samples.AddRange(barchartsComponent.Samples);

                sampleTag = "Boxplot charts";
                var boxplotchartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "boxplotcharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "fe87a15eeb28e2a897e47d8b3d148ded" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "4cf3511ada42e914daacf81ff4dacf7c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "594b0492194317e1528afe906084bfbb" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                    }
                };

                context.Components.Add(boxplotchartsComponent);
                context.Samples.AddRange(boxplotchartsComponent.Samples);

                sampleTag = "Bubble charts";
                var bubblechartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "bubblecharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "eb5c413d66d06517c79b046c8bed0230" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "binding-to-grouped-data", gist = "2c43ccccbc448b8d822c1391a3959ba7" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-grouped-data" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "1dbd9a802369b406b9e533652bd96b1a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "f50e2378993718c7188224d5d9da179d" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                    }
                };

                context.Components.Add(bubblechartsComponent);
                context.Samples.AddRange(bubblechartsComponent.Samples);

                sampleTag = "Bullet charts";
                var bulletchartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "bulletcharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "fc0b95893b3e58ecb024724b98336272" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "914b5e0cd48e233cd78b7e217eeb9f6a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "2408bf732a235e61c8ce655847b3aa9f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                    }
                };

                context.Components.Add(bulletchartsComponent);
                context.Samples.AddRange(bulletchartsComponent.Samples);

                sampleTag = "Donut charts";
                var donutchartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "donutcharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "6539bb554f5d4bd29c8ec8d8f457b9d4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "51083c854c97e4186698e360bbd365ea" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "9186bff1dd24ca2ea193a809f02e96a1" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                    }
                };

                context.Components.Add(donutchartsComponent);
                context.Samples.AddRange(donutchartsComponent.Samples);

                sampleTag = "Dialog";
                var dialogComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "dialog" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "58d4f7efe5f553d9ce210c8c11ad5c86" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "predefined-dialogs", gist = "7534f1dcdec23821743a2dd0eb989b07" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "predefined-dialogs" } } },
                        new Sample() { Name = "events", gist = "47436dd6824400cfb988d8700df4eb1b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "API", gist = "52739173aaafd197546b479816decf4e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "API" } } },
                    }
                };

                context.Components.Add(dialogComponent);
                context.Samples.AddRange(dialogComponent.Samples);

                sampleTag = "Funnel charts";
                var funnelchartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "funnelcharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "4f64b4d5396df91f5d8b6c209357c868" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "funnel-labels", gist = "7d44c56717d3cd5e07265ca7c2b69772" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "funnel-labels" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "9dab6cc0dc524464c39c231fa9ceca04" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "8549645736fbb111e7ffc18e00904351" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                    }
                };

                context.Components.Add(funnelchartsComponent);
                context.Samples.AddRange(funnelchartsComponent.Samples);

                sampleTag = "Line charts";
                var linechartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "linecharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "a6458eaf7ddc8fa196f6237e5d64a7b6" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "3f6c016feeabd6ba64d2cd1161ce874f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "eeb823a34b7511e766388cc7f9c9e8ef" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "binding-to-grouped-data", gist = "6590464f69782855bab8e1b07cd3e54b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-grouped-data" } } },
                        new Sample() { Name = "date-axis", gist = "8073bdb02a2fd434349cc82c940eb293" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "date-axis" } } },
                        new Sample() { Name = "error-bars", gist = "f567042719af5d839f9bb29d7dc0c931" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "error-bars" } } },
                        new Sample() { Name = "logarithmic-axis", gist = "d68317bfb379afa552fcd94d4d739a8e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "logarithmic-axis" } } },
                        new Sample() { Name = "multi-axis", gist = "c1617b4418d1ec9062e3e62c2f0669d6" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "multi-axis" } } },
                        new Sample() { Name = "smooth-line", gist = "e83fd544f952696229529d7abed733a0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "smooth-line" } } },
                        new Sample() { Name = "stacked-line", gist = "3b57e59006cd2897b1aa4e362267c78c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "stacked-line" } } },
                        new Sample() { Name = "stepped-line", gist = "6ac5f6081df954460b1417df8059090c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "stepped-line" } } },
                    }
                };

                context.Components.Add(linechartsComponent);
                context.Samples.AddRange(linechartsComponent.Samples);

                sampleTag = "Pie charts";
                var piechartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "piecharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "e23348dda7d4972798d9831aeb0e6800" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "pie-labels", gist = "5379a2bf2384478063223b2474d1ac10" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "pie-labels" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "e750c35511eb82de377b5a96536de877" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "37db556f603db39caa055d06eda691ca" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                    }
                };

                context.Components.Add(piechartsComponent);
                context.Samples.AddRange(piechartsComponent.Samples);

                sampleTag = "Polar charts";
                var polarchartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "polarcharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "binding-to-local-data", gist = "10ee70a457a0150fa63ad1719670ef77" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "057112820ff62411669c2028580c39b3" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "polar-area", gist = "b0b6bc45bdec0ea80a0d0f9062f63e7d" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "polar-area" } } },
                        new Sample() { Name = "polar-line", gist = "a626125692fe226d9992d9f700c871ba" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "polar-line" } } },
                        new Sample() { Name = "polar-scatter", gist = "012c729e732d94a050fb4b9ed27b23f4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "polar-scatter" } } },
                        new Sample() { Name = "smooth-polar-line", gist = "0064e6a1d9ce8b9a5b4a7147a85753fe" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "smooth-polar-line" } } },
                    }
                };

                context.Components.Add(polarchartsComponent);
                context.Samples.AddRange(polarchartsComponent.Samples);

                sampleTag = "Radar charts";
                var radarchartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "radarcharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "radar-line", gist = "8fc2711dc42bc80153108510ebe75b64" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "radar-line" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "83b82d2724a8a708de370c712e8149df" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "51f56906397adebd1f2ff0e24245ba97" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "binding-to-grouped-data", gist = "49a5bcc317dfc06ffe357a55431da200" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-grouped-data" } } },
                        new Sample() { Name = "radar-area", gist = "34c7af10d93e8f567b8d4a2cb08e2535" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "radar-area" } } },
                        new Sample() { Name = "smooth-radar-line", gist = "f3e2c5797397d49cd1ed438c6dba34af" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "smooth-radar-line" } } },
                    }
                };

                context.Components.Add(radarchartsComponent);
                context.Samples.AddRange(radarchartsComponent.Samples);

                sampleTag = "Range charts";
                var rangechartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "rangecharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "1c5930570481f2a3ce8ba839bbee7292" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "363d598ce0897945ff979b58b6cd0594" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "157d3eb4dec04638ae09855af0dc44c4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                    }
                };

                context.Components.Add(rangechartsComponent);
                context.Samples.AddRange(rangechartsComponent.Samples);

                sampleTag = "Scatter charts";
                var scatterchartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "scattercharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "135c28200c866da4b6dd429d699493b6" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "scatter-line-chart", gist = "3b4c0b3f8e0e55f99d5c3413b0860d5d" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "scatter-line-chart" } } },
                        new Sample() { Name = "smooth-scatter-line", gist = "a135a349f25c0fa0447d7983f23a5969" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "smooth-scatter-line" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "0d9b568acaeaa3138cf3ebdc0cf23586" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "bdd0cfed65a9009d2989e3b1dfd4b5ee" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "binding-to-grouped-data", gist = "2f3a35e6a21832b6763a2f7d6a28b3f9" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-grouped-data" } } },
                        new Sample() { Name = "custom-pan-and-zoom", gist = "48618d062c9a6417ec398d5dab435bd1" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "custom-pan-and-zoom" } } },
                        new Sample() { Name = "date-axis", gist = "a552065d962b69bb110038b7754114ae" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "date-axis" } } },
                        new Sample() { Name = "multi-axis", gist = "58a9d25eac311c2662e7dd51db1429ad" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "multi-axis" } } },
                        new Sample() { Name = "pan-and-zoom", gist = "31057d7943a3a2799d7e72c9529b4567" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "pan-and-zoom" } } },
                    }
                };

                context.Components.Add(scatterchartsComponent);
                context.Samples.AddRange(scatterchartsComponent.Samples);

                sampleTag = "Sparkline";
                var sparklineComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "sparkline" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "a09da4f3cc5a41c5f1ac14e9734f7ca2" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "aurelia", gist = "02a15fa13371c6c9c74a8133e32dcfed" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "aurelia" } } },
                        new Sample() { Name = "remote-data", gist = "f48e87c1bbfea277a86b1d5f25734711" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "remote-data" } } },
                    }
                };

                context.Components.Add(sparklineComponent);
                context.Samples.AddRange(sparklineComponent.Samples);

                sampleTag = "Stock";
                var stockComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "stock" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "2fa99251839134c13b00e30e9a92028a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "multiple-panes", gist = "47c0a7230422c86ebd28859691833d06" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "multiple-panes" } } },
                        new Sample() { Name = "virtualization", gist = "0fbf4ba2eb188a13466e60913dce4a77" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "virtualization" } } },
                        new Sample() { Name = "pdf-export", gist = "680e06379f8fdacb1f40630bfa4bf188" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "pdf-export" } } },
                    }
                };

                context.Components.Add(stockComponent);
                context.Samples.AddRange(stockComponent.Samples);

                sampleTag = "Treemap";
                var treemapComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "treemap" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "fa25d186446e61db7eef364a9e2284d7" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "events", gist = "039d8d440fc3cecd3dec4e8737e29a1a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                    }
                };

                context.Components.Add(treemapComponent);
                context.Samples.AddRange(treemapComponent.Samples);

                sampleTag = "Waterfall charts";
                var waterfallchartsComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "waterfallcharts" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "b776d58c732e2ae0023446a8fd9d87ff" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "d6166d32b0de5ff2c6a535d7a9f4df1e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "2714095a3106da42f9cbab4fe7798fc3" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "horizontal-waterfall", gist = "e8c54329e09c97617f0cd5f1f1d67abe" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "horizontal-waterfall" } } },
                    }
                };

                context.Components.Add(waterfallchartsComponent);
                context.Samples.AddRange(waterfallchartsComponent.Samples);

                sampleTag = "Color Picker";
                var colorpickerComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "colorpicker" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "a346680615fca14ec68b94b0c3a47e01" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "flat", gist = "cae4c7b65d72a7afeee276895bea93e3" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "flat" } } },
                        new Sample() { Name = "standalone-palette", gist = "ad93cc5a267e9705b4c9c90da8702613" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "standalone-palette" } } },
                        new Sample() { Name = "api", gist = "7209cb103dd9b943360c715a5812db3d" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(colorpickerComponent);
                context.Samples.AddRange(colorpickerComponent.Samples);

                sampleTag = "ComboBox";
                var comboboxComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "combobox" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "3d3d426dd4b7e6b2ce802874203e9b3b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "api", gist = "492bbae5065f4c41ea63a4ea30bbb130" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "cascading-combobox", gist = "9684cd63be624b459aff9fa960b9a0a4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "cascading-combobox" } } },
                        new Sample() { Name = "customizing-templates", gist = "8e5ba644672f1f9e5343e20cba8521c3" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "customizing-templates" } } },
                        new Sample() { Name = "grouping", gist = "6eca8fe719a3ac01998fc2449b3e0376" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "grouping" } } },
                        new Sample() { Name = "server-filtering", gist = "cccfced2d934b47428cfb66225f7ca69" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "server-filtering" } } },
                        new Sample() { Name = "virtualization", gist = "19dc80f295a5c0a012988e679d938e86" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "virtualization" } } },
                        new Sample() { Name = "events", gist = "81feb1b3bc970ceb7755700f78d65eb9" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                    }
                };

                context.Components.Add(comboboxComponent);
                context.Samples.AddRange(comboboxComponent.Samples);

                sampleTag = "DatePicker";
                var datepickerComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "datepicker" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-usage", gist = "10ba464aa1fa03e85929f38c2d453976" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-usage" } } },
                        new Sample() { Name = "range-selection", gist = "da7b4e7a68f8cde49861c3cfc7e5eb73" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "range-selection" } } },
                        new Sample() { Name = "events", gist = "9efa72eb9d3bbcc53216c0d2fbca762e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "107e952698bfca74afe371970c564fe0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "binding", gist = "0cbaf26be35fedc38c917961f4f78b84" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding" } } },
                    }
                };

                context.Components.Add(datepickerComponent);
                context.Samples.AddRange(datepickerComponent.Samples);

                sampleTag = "DateTimePicker";
                var datetimepickerComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "datetimepicker" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-usage", gist = "516ba5f537c7bc127745b837e5436fe2" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-usage" } } },
                        new Sample() { Name = "range-selection", gist = "b5fb73e8d3ea379df3c6dcb4b12cdb23" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "range-selection" } } },
                        new Sample() { Name = "customizing-templates", gist = "ffaf00ea31be44d5ffb362e50b6d7e61" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "customizing-templates" } } },
                        new Sample() { Name = "events", gist = "34bf2ff76c0d0a34bae6ff4bcdb2187a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "edfaa3a0f7e6228132c73402c5b787bc" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "disable-dates", gist = "1f971bb5ebf8c3c844ad0bad88071a20" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "disable-dates" } } },
                    }
                };

                context.Components.Add(datetimepickerComponent);
                context.Samples.AddRange(datetimepickerComponent.Samples);

                sampleTag = "Filter Menu";
                var filtermenuComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "filtermenu" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "c85a983f00cb93abc7ee78423e729cd5" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                    }
                };

                context.Components.Add(filtermenuComponent);
                context.Samples.AddRange(filtermenuComponent.Samples);

                sampleTag = "Diagram";
                var diagramComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "diagram" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "bc01152ddc63bf3bdbcff6aaa341328f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "built-in-layouts", gist = "4cd011a055b1279b0aa5a31491b129df" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "built-in-layouts" } } },
                        new Sample() { Name = "editing", gist = "c9e385a852d08f04d7b10c1fa5cdf1ca" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "editing" } } },
                        new Sample() { Name = "pdf-export", gist = "d191e89a30ed160d7f3ff0dffcb9c91a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "pdf-export" } } },
                        new Sample() { Name = "advanced-export", gist = "afb1810a7ca6a099bbff71e4fe31a396" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "advanced-export" } } },
                        new Sample() { Name = "events", gist = "0c8ebef7d4c76c1c70a6a53ed8305103" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "887307d318854f37ca16d13015f96c3a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(diagramComponent);
                context.Samples.AddRange(diagramComponent.Samples);

                sampleTag = "Drag and Drop";
                var draganddropComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "draganddrop" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "77c1b896c487f13ce2efa2081ba413e3" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "container", gist = "261aa4bc48cf25a3c63a8646e1f919a4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "container" } } },
                        new Sample() { Name = "area", gist = "6a11e020dc53f7218dd07ae4dc30c1e5" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "area" } } },
                        new Sample() { Name = "events", gist = "e12e174496990c0ed8d0c6cd8fc98e86" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                    }
                };

                context.Components.Add(draganddropComponent);
                context.Samples.AddRange(draganddropComponent.Samples);

                sampleTag = "DropDownList";
                var dropdownlistComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "dropdownlist" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "4fdf47666ebe68f91c4450147ea27db4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "api", gist = "438d68bc6e699aa469bd64ba87445b9b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "e65e518c38113c9eb95c2680890effa6" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "cascading-dropdownlist", gist = "58c07d12a001ddb35900e9a93029fa7b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "cascading-dropdownlist" } } },
                        new Sample() { Name = "customizing-templates", gist = "b94d4f9c68e1ace4cbaf417ccd581f29" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "customizing-templates" } } },
                        new Sample() { Name = "grouping", gist = "0e26beac89215fbaf4e5081f625bb05b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "grouping" } } },
                        new Sample() { Name = "server-filtering", gist = "34ab660c471686afb8617123b328e2dc" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "server-filtering" } } },
                        new Sample() { Name = "virtualization", gist = "4acd16e5c3767a79346f649ad86baf1c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "virtualization" } } },
                        new Sample() { Name = "events", gist = "e6175d8db7adcbd7f7385a92434df6eb" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "datasource", gist = "3a2752719d277371e472bbcec8463f74" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "datasource" } } },
                    }
                };

                context.Components.Add(dropdownlistComponent);
                context.Samples.AddRange(dropdownlistComponent.Samples);

                sampleTag = "Editor";
                var editorComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "editor" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "79510f53f025ecd6994d783b0c4d8ad2" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "api", gist = "03238b0c321bab00edd951ab569d27c9" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "custom-tools", gist = "02a18e555bee18001337aa6f6c709845" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "custom-tools" } } },
                        new Sample() { Name = "file-and-image-browser", gist = "0108bb40e8a786d0a316fb80f45f51cf" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "file-and-image-browser" } } },
                        new Sample() { Name = "all-tools", gist = "8b661da8c4d5e9297a48e2ffb2100410" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "all-tools" } } },
                        new Sample() { Name = "snippets", gist = "38a390751c156d8f05f2c1ed1783ceee" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "snippets" } } },
                        new Sample() { Name = "styles", gist = "b07a96429d24acaca3c7fd9d0b8aed76" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "styles" } } },
                        new Sample() { Name = "pdf-export", gist = "52e661cfdcccec310fbd0a416c0f998b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "pdf-export" } } },
                        new Sample() { Name = "events", gist = "b211b41c2f5a3ee1b4c9f3f4364e3bf8" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                    }
                };

                context.Components.Add(editorComponent);
                context.Samples.AddRange(editorComponent.Samples);

                sampleTag = "Gantt";
                var ganttComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "gantt" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "f7eaf5528c06fdbb5ebe6cbf4d6c21e5" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "column-resizing", gist = "71f1b6ca77e282dc43f549be3cb79692" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "column-resizing" } } },
                        new Sample() { Name = "exporting-to-pdf", gist = "c8a1a93ebfd08961d108bc77c491981f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "exporting-to-pdf" } } },
                        new Sample() { Name = "resources", gist = "6731b9a965df22f94f536a654a6162ac" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "resources" } } },
                        new Sample() { Name = "events", gist = "c0ec0e60b047077fd5dfd216fbd6c836" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "fd1ea515c9bae370097b3306943486d4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "task-template", gist = "db74cce84384a9fb81084c24b6c32254" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "task-template" } } },
                    }
                };

                context.Components.Add(ganttComponent);
                context.Samples.AddRange(ganttComponent.Samples);

                sampleTag = "Generic";
                var genericComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "generic" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "use-widget-on-initialization", gist = "c2ffde936c8caee5c35b3c08a596b410" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "use-widget-on-initialization" } } },
                        new Sample() { Name = "without-auto-initialization", gist = "8dcdecc6005a02a4c0d5770ea0aa954c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "without-auto-initialization" } } },
                        new Sample() { Name = "two-way-binding-support", gist = "0cbaf26be35fedc38c917961f4f78b84" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "two-way-binding-support" } } },
                        new Sample() { Name = "recreate", gist = "38ead64ee92d684da566078b1a0f65c2" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "recreate" } } },
                    }
                };

                context.Components.Add(genericComponent);
                context.Samples.AddRange(genericComponent.Samples);

                sampleTag = "Grid";
                var gridComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "grid" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "b6a4f607d9f42a0e792e20779fe34213" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "datasource-read", gist = "5e95513ef8cef2d07b2fc4c2cd422137" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "datasource-read" } } },
                        new Sample() { Name = "batch-editing", gist = "985fcf8ccc29cb20a77d24eadd97af66" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "batch-editing" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "e30182438a95ab16af7ac82a9f073e10" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "f4f79fa5e2a21d0846f81326a7a86329" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "binding-to-signalr", gist = "7452d3f7918349a144d198feffb91d1e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-signalr" } } },
                        new Sample() { Name = "editing-custom-editor", gist = "2cb6a4819f8782554cc23d03983b560b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "editing-custom-editor" } } },
                        new Sample() { Name = "frozen-columns", gist = "85326fd431dda68665b29f88be1fb362" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "frozen-columns" } } },
                        new Sample() { Name = "initialization-from-table", gist = "7ae8d98882fed6ada9d6089f294c9677" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "initialization-from-table" } } },
                        new Sample() { Name = "inline-editing", gist = "a8e0ed26d98b73b66d6b8b6ecc1386d0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "inline-editing" } } },
                        new Sample() { Name = "popup-editing", gist = "bda38c5914d7c6515cfe144d094326ea" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "popup-editing" } } },
                        new Sample() { Name = "working-offline", gist = "6da9d46a5f72e495dd829f5b4d9f7524" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "working-offline" } } },
                        new Sample() { Name = "detail-template", gist = "f46f6b5236c7442191c7d7224a9598d9" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "detail-template" } } },
                        new Sample() { Name = "toolbar-template", gist = "fd5cfa0b90a7f6289c1c7789cb96757b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "toolbar-template" } } },
                        new Sample() { Name = "advanced", gist = "8f6d1acee3f711337cf9416a2ca3c364" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "advanced" } } },
                        new Sample() { Name = "custom-grid-width", gist = "f596b919e7f956b85a16dfac3166354b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "custom-grid-width" } } },
                        new Sample() { Name = "multi-column-headers", gist = "3e056bf0bb5372cbf02ccb6a7d99a4f8" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "multi-column-headers" } } },
                        new Sample() { Name = "colours", gist = "c5a1a96826d79e752696b82465f89c83" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "colours" } } },
                        new Sample() { Name = "row-select", gist = "ea47f99e2a278259f2409ba3a2bca189" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "row-select" } } },
                        new Sample() { Name = "row-select-programatically", gist = "00a7c83b7d9560349c64b723e5e5fb27" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "row-select-programatically" } } },
                        new Sample() { Name = "row-click", gist = "9dab0510645805aa3d8963b9f2803bc6" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "row-click" } } },
                        new Sample() { Name = "two-way-binding", gist = "43c4485cd73fd35f17052b334ffe671e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "two-way-binding" } } },
                        new Sample() { Name = "without-auto-initialization", gist = "025ec1b83149711ddfbcdcc13232c016" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "without-auto-initialization" } } },
                        new Sample() { Name = "conditional-button", gist = "f320b6c28ca572527b95a332889ad3bc" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "conditional-button" } } },
                        new Sample() { Name = "row-template", gist = "8875df839946569be00c7b99d36533ff" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "row-template" } } },
                        new Sample() { Name = "format-date", gist = "fb98400004a2af1a94d645e634ed232a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "format-date" } } },
                        new Sample() { Name = "virtualization", gist = "8dc9218a2a5a8e9cdbae501b5833f9d5" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "virtualization" } } },
                        new Sample() { Name = "excel-export", gist = "60de7a7bc488cf3ca9741ce3b2e10000" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "excel-export" } } },
                        new Sample() { Name = "grouping", gist = "f4f6698bd09ba23abb2cfac5bb8e4821" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "grouping" } } },
                        new Sample() { Name = "dynamic-columns", gist = "61b50f4dcb59b6cd856d8713034e3979" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "dynamic-columns" } } },
                        new Sample() { Name = "persisting-state", gist = "2334709a09607893f17f7d802e98c404" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "persisting-state" } } },
                        new Sample() { Name = "messages", gist = "5999780541967b08979df9e16839deb4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "messages" } } },
                        new Sample() { Name = "commands", gist = "c9137f24d637706d81ce2f1feeea43b0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "commands" } } },
                    }
                };

                context.Components.Add(gridComponent);
                context.Samples.AddRange(gridComponent.Samples);

                sampleTag = "Linear gauge";
                var lineargaugeComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "lineargauge" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "2b02abaea96bff7889c1e1cad0c7aa2b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "scale-options", gist = "d075f7fc789f52bb0fdd19525507dce7" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "scale-options" } } },
                        new Sample() { Name = "multiple-pointers", gist = "582533791b3ff226fe9e204f45fc54ec" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "multiple-pointers" } } },
                        new Sample() { Name = "export", gist = "ed29d47aa25767fb5b8feac9c275cca7" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "export" } } },
                    }
                };

                context.Components.Add(lineargaugeComponent);
                context.Samples.AddRange(lineargaugeComponent.Samples);

                sampleTag = "ListView";
                var listviewComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "listview" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "c76e763d64c2d3244e222d32f0de062f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "113988da53a5282b87b0316058f493ca" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "editing", gist = "313d5d982d0a795985bbf74194cb7307" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "editing" } } },
                        new Sample() { Name = "selection", gist = "00b00a855bd09a5e055e1a37500a5fba" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "selection" } } },
                        new Sample() { Name = "checkboxes", gist = "53bdd9fb5eec6a26272f6da22a323c9c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "checkboxes" } } },
                    }
                };

                context.Components.Add(listviewComponent);
                context.Samples.AddRange(listviewComponent.Samples);

                sampleTag = "Map";
                var mapComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "map" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "1435787ccfa311c3c5442aceff200d65" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "api", gist = "7676f046b64ee8e7d4d6da14befdbf79" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "binding-markers-to-remote-data", gist = "6c5d62de3281897848180a8da26d824c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-markers-to-remote-data" } } },
                        new Sample() { Name = "bing-tile-layer", gist = "ded5a645f7695174f2b08eae9b8865c2" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "bing-tile-layer" } } },
                        new Sample() { Name = "bubble-layer", gist = "d4582c2f8d34c57358e111cacd2f9157" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "bubble-layer" } } },
                        new Sample() { Name = "binding-to-geojson", gist = "70ae080fd0a9a07569d1adbbbfda4044" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-geojson" } } },
                        new Sample() { Name = "export", gist = "efc0f62c59389a5e7fd164398d2135d5" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "export" } } },
                        new Sample() { Name = "events", gist = "c42ca5e0aa6c52d0af65f164a644f7e2" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                    }
                };

                context.Components.Add(mapComponent);
                context.Samples.AddRange(mapComponent.Samples);

                sampleTag = "MaskedTextBox";
                var maskedtextboxComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "maskedtextbox" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-usage", gist = "b1d08691c1ed74c54f4a045203775504" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-usage" } } },
                        new Sample() { Name = "events", gist = "5ec8ec81f86bcbd9a16ae9af3bb47940" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "e6e47eb53cd2cdfb7159caea55f9a946" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(maskedtextboxComponent);
                context.Samples.AddRange(maskedtextboxComponent.Samples);

                sampleTag = "Menu";
                var menuComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "menu" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "c411702f31dc03bf4ba17324d1b20cdb" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "images", gist = "f3d4551ab3cda74ccb095a74e25edb8e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "images" } } },
                        new Sample() { Name = "direction", gist = "d4a0dc1f22e5bea9d7207da9e0e04b63" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "direction" } } },
                        new Sample() { Name = "orientation", gist = "4b5263ae26a1819668abd906ddb27477" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "orientation" } } },
                        new Sample() { Name = "animation-effects", gist = "0864f364a041ec566d77fe740a0d7fb6" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "animation-effects" } } },
                        new Sample() { Name = "events", gist = "fbb306bd43b15402fd1e808197029cab" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "b263b228d69d6af197479ae3410fd98c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "context-menu", gist = "e09e3e4c04c59db383deb09a8a7e0fe7" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "context-menu" } } },
                    }
                };

                context.Components.Add(menuComponent);
                context.Samples.AddRange(menuComponent.Samples);

                sampleTag = "Multiselect";
                var multiselectComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "multiselect" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "338b9ddfbdfe1bde3f47817818797d96" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "server-filtering", gist = "adb02ab2b183885dcaccb1a31bc86cc0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "server-filtering" } } },
                        new Sample() { Name = "virtualization", gist = "c554a5d7cc6264fdb9022fcd274ed637" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "virtualization" } } },
                        new Sample() { Name = "grouping", gist = "4bebbf5040798ff6f54160f41e137c0f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "grouping" } } },
                        new Sample() { Name = "customizing-templates", gist = "858420aeb1e75d8be963882a48ba3147" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "customizing-templates" } } },
                        new Sample() { Name = "events", gist = "e800211f0afcfca69b6c73aeee20652d" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "3294686ce01ca3de75d7a40ac61e9872" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "tag-mode", gist = "f1e2e79cb08c5ea7e442aedb5b909250" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "tag-mode" } } },
                        new Sample() { Name = "tag-template", gist = "d097611750aecbf60a8fdb400b3e2efe" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "tag-template" } } },
                    }
                };

                context.Components.Add(multiselectComponent);
                context.Samples.AddRange(multiselectComponent.Samples);

                sampleTag = "Notification";
                var notificationComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "notification" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "221b33b880c62eacdd22a001333e2017" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "position-and-stacking", gist = "877ca35ecd95b0f601072aebe44b9468" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "position-and-stacking" } } },
                        new Sample() { Name = "templates", gist = "46eda80ba7db36d5795c8a72792227ef" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "templates" } } },
                        new Sample() { Name = "events", gist = "0f99a16af84974f2e2fdbc1a14fa10d8" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                    }
                };

                context.Components.Add(notificationComponent);
                context.Samples.AddRange(notificationComponent.Samples);

                sampleTag = "Numerictextbox";
                var numerictextboxComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "numerictextbox" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-usage", gist = "f22b873321e4bf94c32b9ced555e3971" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-usage" } } },
                        new Sample() { Name = "events", gist = "769412be8660cddeefcaa1bb99df70af" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "6fbeb6426db3559ee315b09374b1db3c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(numerictextboxComponent);
                context.Samples.AddRange(numerictextboxComponent.Samples);

                sampleTag = "PanelBar";
                var panelbarComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "panelbar" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "9427297a4fe0d32ec6c1dd6d5e98de95" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "images", gist = "4784590d152425454eb8cabfd746e234" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "images" } } },
                        new Sample() { Name = "ajax", gist = "d3a77c869e1548545d4c71b9126531ec" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "ajax" } } },
                        new Sample() { Name = "events", gist = "575ec7ad6303f0e773801880690642a3" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "3ca125a4949ecd5686b778c22464cfa0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(panelbarComponent);
                context.Samples.AddRange(panelbarComponent.Samples);

                sampleTag = "Pivot Grid";
                var pivotgridComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "pivotgrid" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "ef19b41f12595b6550967a3588f677a0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "kpi-measures", gist = "6d431ce415c5c07ba1d5f6dc334c4f1a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "kpi-measures" } } },
                        new Sample() { Name = "remote-binding", gist = "d939354107b08b717730e7c0ea388d71" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "remote-binding" } } },
                        new Sample() { Name = "local-binding", gist = "4b3a368ea54ce5a8c892c6a6849203bd" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "local-binding" } } },
                        new Sample() { Name = "templates", gist = "13d861f06c32c74be6fd0fce360230ef" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "templates" } } },
                        new Sample() { Name = "export-to-excel", gist = "cd1a022805c0dc68d0672cf56f97c7dc" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "export-to-excel" } } },
                        new Sample() { Name = "export-to-pdf", gist = "a001494bb57d5a9bba114952b75a5684" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "export-to-pdf" } } },
                    }
                };

                context.Components.Add(pivotgridComponent);
                context.Samples.AddRange(pivotgridComponent.Samples);

                sampleTag = "Popup";
                var popupComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "popup" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "d8b8e6650ff3d2604d411273187a89a4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                    }
                };

                context.Components.Add(popupComponent);
                context.Samples.AddRange(popupComponent.Samples);

                sampleTag = "Progress Bar";
                var progressbarComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "progressbar" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "2294b53ecebadbe3ddb72ef787b5b2b0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "chunk-progressbar", gist = "34be04685e21ad9daf0347ac1b21c32b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "chunk-progressbar" } } },
                        new Sample() { Name = "vertical-progressbar", gist = "25bf4ea0079009a030cf32c8c2cc2adc" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "vertical-progressbar" } } },
                        new Sample() { Name = "custom-label", gist = "df1c55ea36ef1b57aeb55c130301efca" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "custom-label" } } },
                        new Sample() { Name = "events", gist = "3095c073db09fc1b780f7d043fc5f516" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "c21b49a2bb4a72289a3fe30776714484" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(progressbarComponent);
                context.Samples.AddRange(progressbarComponent.Samples);

                sampleTag = "QR Code";
                var qrcodeComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "qrcode" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "4228ea8ae2900dde0d161585f737a9f8" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "api", gist = "c3244f0c4846b6f8815172f21a1af126" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(qrcodeComponent);
                context.Samples.AddRange(qrcodeComponent.Samples);

                sampleTag = "Radial gauge";
                var radialgaugeComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "radialgauge" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "1c198a2a4376c1d39e8d3682a152a56c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "scale-options", gist = "8d9a7265df061953b5d6620e88e6a62e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "scale-options" } } },
                        new Sample() { Name = "multiple-pointers", gist = "7cdfe42456afcae7c8029797bc6a0893" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "multiple-pointers" } } },
                        new Sample() { Name = "export", gist = "faef9f45e80122ca586b5224e25344cb" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "export" } } },
                    }
                };

                context.Components.Add(radialgaugeComponent);
                context.Samples.AddRange(radialgaugeComponent.Samples);

                sampleTag = "RangeSlider";
                var rangesliderComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "rangeslider" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "7b1e9faa95abc70758d238d06c254eb1" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "events", gist = "1af0265763f8022469287faa8c0b6cd8" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "8d6174d8c625ded9355d8992c71e9cb3" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(rangesliderComponent);
                context.Samples.AddRange(rangesliderComponent.Samples);

                sampleTag = "ResponsivePanel";
                var responsivepanelComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "responsivepanel" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "77a5eb25f93b93aced2c2848a1f77ffc" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                    }
                };

                context.Components.Add(responsivepanelComponent);
                context.Samples.AddRange(responsivepanelComponent.Samples);

                sampleTag = "Scheduler";
                var schedulerComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "scheduler" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "0e1011f393130ce281419b1fb85e268c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "api", gist = "810f392b86c83ed6ffa20ad12f3e64d9" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "events", gist = "3635fcfb182b3971d6ea450f6f0be2db" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "export-to-pdf", gist = "7998c3346699b054dfbca4596e0bc105" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "export-to-pdf" } } },
                        new Sample() { Name = "horizontal-grouping", gist = "e21375f26ecd2c9317262d99e3db2931" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "horizontal-grouping" } } },
                        new Sample() { Name = "timeline-view", gist = "09a6d980a20ba3f4101a10e797f71c77" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "timeline-view" } } },
                        new Sample() { Name = "templates", gist = "8b5f7c883ecf91648f769a1ac817a410" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "templates" } } },
                        new Sample() { Name = "restrictions", gist = "b9f4ec0a08915930dc15f561b65ce676" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "restrictions" } } },
                        new Sample() { Name = "event-move-and-resize", gist = "59d99124ac8756561337d2f7d83f87bd" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "event-move-and-resize" } } },
                        new Sample() { Name = "binding-to-signalr", gist = "5cbafc862cb6475445291f5798fd8110" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-signalr" } } },
                    }
                };

                context.Components.Add(schedulerComponent);
                context.Samples.AddRange(schedulerComponent.Samples);

                sampleTag = "Scrollview";
                var scrollviewComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "scrollview" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "7127cdd2f0d4f2799df8a202e82507c1" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                    }
                };

                context.Components.Add(scrollviewComponent);
                context.Samples.AddRange(scrollviewComponent.Samples);

                sampleTag = "Slider";
                var sliderComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "slider" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "387c43948dc83acf59ea3497472bdfe9" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "events", gist = "d5ff55833b1ffb94745802445c4a9487" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "0bb0207877b5b27692d5e139e91f6bf8" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(sliderComponent);
                context.Samples.AddRange(sliderComponent.Samples);

                sampleTag = "Sortable";
                var sortableComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "sortable" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "90d5fefd37ee4a406e8078fd93650e02" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "disable-items", gist = "e651119fab211f5c1bac06fa2ca39573" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "disable-items" } } },
                        new Sample() { Name = "handlers", gist = "f01c824da3ca27c356da2e558b7ea54e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "handlers" } } },
                        new Sample() { Name = "axis-constraints", gist = "34a3f122ee1c9f70055bcb2cf30812e4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "axis-constraints" } } },
                        new Sample() { Name = "linked-lists", gist = "bfd9ff2983e540f2eb8214afbf8a25d5" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "linked-lists" } } },
                        new Sample() { Name = "events", gist = "6321819c9a494ecafcc94e8b09778fd6" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "sortable-panels", gist = "87140059bfc140a770e9b7c356508b88" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "sortable-panels" } } },
                        new Sample() { Name = "drag-drop", gist = "cb90e9f67690fa7044cb82b3be7c6827" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "drag-drop" } } },
                    }
                };

                context.Components.Add(sortableComponent);
                context.Samples.AddRange(sortableComponent.Samples);

                sampleTag = "Splitter";
                var splitterComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "splitter" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "0f1b37211ebeff0e9b9754239633ae32" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "ajax", gist = "980dc69f6cc998880d4c4ee2357ac4a9" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "ajax" } } },
                        new Sample() { Name = "events", gist = "4f25e0246d873c2525dae55db2184127" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "0a2b41ef3b3c749a5b182f72360258ac" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(splitterComponent);
                context.Samples.AddRange(splitterComponent.Samples);

                sampleTag = "Spreadsheet";
                var spreadsheetComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "spreadsheet" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "662bd7191d5312de5192c4f45516e93c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "sorting-and-filtering", gist = "8b99f2734b37277da12617ab7aa5e40c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "sorting-and-filtering" } } },
                        new Sample() { Name = "server-import-export", gist = "a0cca8e940669c6c54bb9c70e7470713" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "server-import-export" } } },
                        new Sample() { Name = "server-export-to-pdf", gist = "5abf1b281ee5963570cec991c1b939e7" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "server-export-to-pdf" } } },
                        new Sample() { Name = "datasource-binding", gist = "e32bf0bcc1a81d6ad0dc561761cb8bde" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "datasource-binding" } } },
                        new Sample() { Name = "disabled-cells", gist = "7d2c75f4fdc045bbf088dbab63d4d360" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "disabled-cells" } } },
                        new Sample() { Name = "events", gist = "dacb3e616433467dc50b2959b48558c3" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "validation", gist = "524ccaf22276b759632041879ef9d6aa" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "validation" } } },
                    }
                };

                context.Components.Add(spreadsheetComponent);
                context.Samples.AddRange(spreadsheetComponent.Samples);

                sampleTag = "Switch";
                var switchComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "switch" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "0bf7f350645b621fdd03b034850bfb5d" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "value-binding", gist = "4b02a8822a0c2847815eb166a242409c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "value-binding" } } },
                    }
                };

                context.Components.Add(switchComponent);
                context.Samples.AddRange(switchComponent.Samples);

                sampleTag = "Tabstrip";
                var tabstripComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "tabstrip" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "3b593204e96e3de1cc205f1f39a110f0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "images", gist = "cf625818c800a840670c5e5d7ed7ee43" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "images" } } },
                        new Sample() { Name = "ajax", gist = "771745f94cfab7906a0a79d56bc811af" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "ajax" } } },
                        new Sample() { Name = "animation-effects", gist = "9d9f8fb4f39857a792467f01f7309ca0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "animation-effects" } } },
                        new Sample() { Name = "tab-position", gist = "44305bac1309de4e2cfd3fb5b095db09" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "tab-position" } } },
                        new Sample() { Name = "scrollable-tabs", gist = "7c4cc79ffc31022306befadb93d01256" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "scrollable-tabs" } } },
                        new Sample() { Name = "events", gist = "f9a7d23255d92aa1c7934791776e3932" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "6bd03e516104c53fd57e1f47e47cf183" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(tabstripComponent);
                context.Samples.AddRange(tabstripComponent.Samples);

                sampleTag = "TimePicker";
                var timepickerComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "timepicker" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-usage", gist = "895fcd5e6ebbd939d475641a8a971cde" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-usage" } } },
                        new Sample() { Name = "range-selection", gist = "4d85f704aaf06b35ec66dd8152c8ab00" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "range-selection" } } },
                        new Sample() { Name = "events", gist = "8cbf06fbb60a46c102f628998796fcc4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "dac838ba01fbdc2fa08de0dc36ae218e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(timepickerComponent);
                context.Samples.AddRange(timepickerComponent.Samples);

                sampleTag = "Toolbar";
                var toolbarComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "toolbar" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "fa40f5e95d562ded1a7afbd3ca2af4ef" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "resize", gist = "e4fdb0ce971e435f535bfc224fe5970b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "resize" } } },
                        new Sample() { Name = "events", gist = "1e6cc4a04a1ccb49e2263bfb9829768e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "1b3e340791fdbfa3499eb29c72ca70c7" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "integration-with-editors", gist = "480d780896549dfa3823f3d81ca909a8" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "integration-with-editors" } } },
                    }
                };

                context.Components.Add(toolbarComponent);
                context.Samples.AddRange(toolbarComponent.Samples);

                sampleTag = "Tooltip";
                var tooltipComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "tooltip" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "64b68d83f2396c1af64c4fc12ed983c9" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "ajax", gist = "65f53c19aa96e165c7491e0029dff941" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "ajax" } } },
                        new Sample() { Name = "content-template", gist = "02ee8761c6dbdcfba6ac560c4bfd8c8c" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "content-template" } } },
                        new Sample() { Name = "aurelia-template", gist = "1fa86dc6adda846b0c0ccb5ee21b3035" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "aurelia-template" } } },
                        new Sample() { Name = "events", gist = "82197cbbdacda61272484615553a3b5b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "2860122b823fb0ce8236d8d0ade32758" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(tooltipComponent);
                context.Samples.AddRange(tooltipComponent.Samples);

                sampleTag = "Treeview";
                var treeviewComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "treeview" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "b997bfa412b068081df4e50eba7b6f8f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "drag-drop", gist = "371a9863895a97818c7cf4e4ed22682f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "drag-drop" } } },
                        new Sample() { Name = "images", gist = "5f8163eec131372ac349e67ebf2cf5b1" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "images" } } },
                        new Sample() { Name = "checkboxes", gist = "964fddec811cfe9a76d9cdd02a370dd3" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "checkboxes" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "cef193f4540211c91ff95d344c67ab27" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "2bf6b0df29d8fe32027329b4dfe627a0" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "api", gist = "89fefa6ce44a9b5b0b1e18341b8bab21" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "custom-templates", gist = "3403d8aa310ff01a4da9689226b523d9" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "custom-templates" } } },
                    }
                };

                context.Components.Add(treeviewComponent);
                context.Samples.AddRange(treeviewComponent.Samples);

                sampleTag = "TreeList";
                var treelistComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "treelist" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "0fa38e25bd2f7bdbee06c7d9011176a3" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "binding-to-local-data", gist = "9e39c2328c53d3d7409bc79f0f9e92b3" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-local-data" } } },
                        new Sample() { Name = "binding-to-remote-data", gist = "aa8679d5cc9a7c52800133398c0e16a7" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "binding-to-remote-data" } } },
                        new Sample() { Name = "drag-and-drop", gist = "406ac3782229efc4e14fa68a21b0edc2" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "drag-and-drop" } } },
                        new Sample() { Name = "editing", gist = "b255bb6ab83e05461501d8e0be297e3a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "editing" } } },
                        new Sample() { Name = "popup-editing", gist = "8f0a6fb9aeaeb01a9867345c0c524f81" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "popup-editing" } } },
                        new Sample() { Name = "column-resizing", gist = "973b76ceeb04cd0fa7123471d5dfa1c4" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "column-resizing" } } },
                        new Sample() { Name = "column-reordering", gist = "0106918f3c2ee40599738747566de081" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "column-reordering" } } },
                        new Sample() { Name = "column-menu", gist = "de8fd77a207158a799852091c3001716" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "column-menu" } } },
                        new Sample() { Name = "frozen-columns", gist = "06d3f74211a39df74704c62f736f86e5" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "frozen-columns" } } },
                        new Sample() { Name = "aggregates", gist = "3f5b528c8ab37a6cc47f5161ceb3147a" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "aggregates" } } },
                        new Sample() { Name = "export-to-excel", gist = "0fa7e67c2864f29a0d34f2ee1b7eb5f9" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "export-to-excel" } } },
                        new Sample() { Name = "export-to-pdf", gist = "111ea9e696d301c47c5e34bb1e54089e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "export-to-pdf" } } },
                        new Sample() { Name = "events", gist = "dc1be89684b804e1cbd28ee72f5b5b08" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "f1a7d756663c874ff6b6846d6c109a7e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(treelistComponent);
                context.Samples.AddRange(treelistComponent.Samples);

                sampleTag = "Upload";
                var uploadComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "upload" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "2b8ba24ba8d0c232e1dcd1f73ce68ea2" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "asynchronous-upload", gist = "93747e2c11cb0a7cb3e7aab15e5d38c2" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "asynchronous-upload" } } },
                        new Sample() { Name = "events", gist = "88374a7fec0b98e7858270cef3482796" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "ceffe7bfffe6633bc4e0d5aa990f71f5" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                        new Sample() { Name = "templates", gist = "f314d266b33bdd1879964213fc4f7f34" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "templates" } } },
                        new Sample() { Name = "initial-files", gist = "26806644e3cb05ced1b5059a65397e88" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "initial-files" } } },
                    }
                };

                context.Components.Add(uploadComponent);
                context.Samples.AddRange(uploadComponent.Samples);

                sampleTag = "Validator";
                var validatorComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "validator" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "4ebce7443e1a6461a8a8d3b1c2c89bfe" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "custom-validation", gist = "92695ec465c3338db846cacc6a5cce01" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "custom-validation" } } },
                    }
                };

                context.Components.Add(validatorComponent);
                context.Samples.AddRange(validatorComponent.Samples);

                sampleTag = "ValueConverters";
                var valueconvertersComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "valueconverters" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "857165411925e01e9b407ab097d7e958" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                    }
                };

                context.Components.Add(valueconvertersComponent);
                context.Samples.AddRange(valueconvertersComponent.Samples);

                sampleTag = "Window";
                var windowComponent = new Component()
                {
                    DateCreated = DateTime.UtcNow,
                    Name = sampleTag,
                    CreatorName = "@catalogAdmin",
                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "window" } },
                    Samples = new List<Sample>()
                    {
                        new Sample() { Name = "basic-use", gist = "86fcbc2d847ce483f249b55cfa0defa6" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "basic-use" } } },
                        new Sample() { Name = "customizing-actions", gist = "e26d9beab9c88d98b2429deb304cc50f" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "customizing-actions" } } },
                        new Sample() { Name = "ajax", gist = "22acce55dc013fc8a946da42533aa15b" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "ajax" } } },
                        new Sample() { Name = "grid-in-window", gist = "13ad0a4b1cb9579542b690198791f0e8" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "grid-in-window" } } },
                        new Sample() { Name = "events", gist = "2429e459773cd14192f62b8793716b9e" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "events" } } },
                        new Sample() { Name = "api", gist = "0699192fbb4036dde0503e73af3d2dfe" , sampleTags = new List<SampleTag>() { new SampleTag { sTag = "api" } } },
                    }
                };

                context.Components.Add(windowComponent);
                context.Samples.AddRange(windowComponent.Samples);


                context.SaveChangesAsync();
            }
        }

    }
}
