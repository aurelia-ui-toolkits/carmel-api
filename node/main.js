// main.js

var fs = require('fs');

var str = fs.readFileSync('samples.json', 'utf-8');
var json = JSON.parse(str);
var count = json.categories.length;

GenerateFunctionStart();

for(var i = 0; i < count; i++) {
  var category = json.categories[i];
  var componentName = category.title.replace(/\s/g, "").toLowerCase();

  GenerateSampleHeader(category.title, componentName);

  var samples = category.samples;
  var sampleKeys = Object.keys(samples);

  sampleKeys.forEach(key => {
    var sample = samples[key];
    var gist = sample;

    if (typeof sample === 'object') {
      gist = sample.gist;
    }

    GenerateSampleListSection(key, gist);
    //sampleTitle = sampleTitle.replace(/-/g, ' ');
    //sampleTitle = sampleTitle.charAt(0).toUpperCase() + sampleTitle.slice(1);
    //console.log("  " + sampleTitle + " " + gist);

  });

  GenerateSampleFooter(componentName);
}

GenerateFunctionEnd();

// -----------------------------------------------------------------------

function GenerateFunctionStart() {
  console.log('        public static void CreateSeedData(CatalogContext context)');
  console.log('        {');
  console.log('            if (!context.Components.Any())');
  console.log('            {');
  console.log('                var sampleTag = "";');
  console.log(' ');
}

function GenerateSampleHeader(title, componentName) {
  console.log('                sampleTag = "' + title +'";');
  console.log('                var ' + componentName + 'Component = new Component()');
  console.log('                {');
  console.log('                    DateCreated = DateTime.UtcNow,');
  console.log('                    Name = sampleTag,');
  console.log('                    CreatorName = "@catalogAdmin",');
  console.log('                    ComponentTags = new List<ComponentTag>() { new ComponentTag { cTag = "Example" } },');
  console.log('                    Samples = new List<Sample>()');
  console.log('                    {');
}


function GenerateSampleListSection(sampleName, gist) {
  console.log('                        new Sample() { Name = "' + sampleName + '", gists = new List<Gist>() { new Gist { Url = "' + gist + '"} }, sampleTags = new List<SampleTag>() { new SampleTag { sTag = "' + sampleName + '" } } },');
}

function GenerateSampleFooter(sampleName) {
  console.log('                    }');
  console.log('                };');
  console.log(' ');
  console.log('                context.Components.Add(' + sampleName + 'Component);');
  console.log('                context.Samples.AddRange(' + sampleName + 'Component.Samples);');
  console.log(' ');
}

function GenerateFunctionEnd(){
  console.log(' ');
  console.log('                context.SaveChangesAsync();');
  console.log('            }');
  console.log('        }'); 
}