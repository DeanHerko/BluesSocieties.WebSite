![alt text](wwwroot/images/logos/austin.jpg "Austin Blues Society Logo")

Reference-style:
![alt text][logo]

[logo]: https://github.com/adam-p/markdown-here/raw/master/src/common/images/icon48.png "Logo Title Text 2"

```javascript
    <script src="https://js.arcgis.com/3.18/"></script>
    <script>
        require([
            "esri/arcgis/utils",
            "esri/dijit/LayerList",
            "dijit/layout/BorderContainer",
            "dijit/layout/ContentPane",
            "dojo/domReady!"
        ], function (
            arcgisUtils,
            LayerList
        ) {
            //Create a map based on an ArcGIS Online web map id
            arcgisUtils.createMap("4240fb72057d4ba39f2710dab344558f", "map").then(function (response) {
                //4240fb72057d4ba39f2710dab344558f  /colored picks
                //2a544b02d011436db87e155aea76144f  black/white
                var myWidget = new LayerList({
                    map: response.map,
                    layers: arcgisUtils.getLayerList(response)
                }, "layerList");
                myWidget.startup();
                //map.infoWindow.resize(200, 75);
                map.on("load", function () {
                    // hide the popup's ZoomTo link as it doesn't make sense for cluster features
                    domStyle.set(query("a.action.zoomTo")[0], "display", "none");



                });

            });
        });
    </script>
```

```css
    <link rel="stylesheet" href="https://js.arcgis.com/3.18/dijit/themes/claro/claro.css">
    <link rel="stylesheet" href="https://js.arcgis.com/3.18/esri/css/esri.css">
```
