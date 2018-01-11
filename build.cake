
Task("Run").Does(() => {
  StartProcess("dotnet", new ProcessSettings {
      Arguments = "run --project src/ValueTuple/ValueTuple.csproj --configuration Release"
  });  
});

var target = Argument("target", "default");
RunTarget(target);