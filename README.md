# pede-goggles
<p>Nightvision / Thermalvision script for FiveM</p>

## Installation
<p>Right now this script is made for QBCore.</p>
<p>So you will need to add following to your items.lua</p>
``` ['nightgoggles']                         = {['name'] = 'nightgoggles',                           ['label'] = 'Nightvision Goggles',           ['weight'] = 100,          ['type'] = 'item',         ['image'] = 'goggles.png',                 ['unique'] = true,         ['useable'] = true,      ['shouldClose'] = true,      ['combinable'] = nil,   ['description'] = 'Nightvision goggles'},
    ['thermalgoggles']                        = {['name'] = 'thermalgoggles',                          ['label'] = 'Thermalvision Goggles',           ['weight'] = 100,          ['type'] = 'item',         ['image'] = 'goggles.png',                ['unique'] = true,          ['useable'] = true,      ['shouldClose'] = true,      ['combinable'] = nil,   ['description'] = 'Thermalvision goggles'},  ```


<p>Right now the only configuarble thing is the items inside `Config.lua`</p>
<p>I will work on creating the `Config.ini` later on.</p>

<p>The image i have used for the inventory is https://www.pngegg.com/en/png-yewmw/download?height=100</p>

