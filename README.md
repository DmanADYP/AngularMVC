Visual Studio 2015 Setup
               -Need to have Update 3 installed
                              -to find out please go  to in ribbon
                                             -HELP
                                                            -> About Visual Studios
                                             
               -Need to have Typescript Installed
                              -To Install Go To Following Link
                              https://www.microsoft.com/en-us/download/details.aspx?id=48593
                              -Once Installed restart, may require a full computer restart 
               -Open Visual Studio Project 
                              -Go To
                                             -Tools
                                                            ->Options
                                                                           ->Projects And Solutions 
                                                                                          ->External Web Tools
                                                                                                         ->Make sure $(PATH) second in List
               -Run Project 
                              -Modified Views that enable Angular to Run
                                             -> Shared -> Layouts added following Script
                                  <!-- Angular Code -->
     <base href="/">
     <link rel="stylesheet" href="styles.css">
     <!-- Polyfill(s) for older browsers -->
  <script src="https://cdn.polyfill.io/v2/polyfill.min.js?features=Intl.~locale.en"></script>
     <script src="node_modules/core-js/client/shim.min.js"></script>
<script src="node_modules/zone.js/dist/zone.js"></script>
     <script src="node_modules/reflect-metadata/Reflect.js"></script>
<script src="node_modules/systemjs/dist/system.src.js"></script>
     <script src="systemjs.config.js"></script>
     <script>
      System.import('app').catch(function(err){ console.error(err); });
     </script>
     <!-- Angular Code -->
-> Home -> Index.html
@{
        ViewBag.Title = "Home Page";
}
<div class="jumbotron">
        <h1>Angular  QuickStart</h1>
</div>
<div class="row">
        <div class="col-md-4">
                 <!-- Angular Code -->
                 <my-app>Loading...</my-app>
                 <!-- Angular Code -->
        </div>
</div>
                 -Please note view is now referencing App (folder) ->app.component.ts

