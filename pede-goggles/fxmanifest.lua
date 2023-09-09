fx_version 'adamant'

game 'gta5'

description 'Pede goggles'

version '1.0'

shared_scripts {
  'Configs/Config.lua',
  'Configs/Config.ini',
  'Config.xml',  
}

client_scripts {
  'Client/Client.net.dll',
  'Client/Client.lua',
  'Configs/Config.ini',
}

server_scripts {
  'Server/Server.lua',
  'Configs/Config.ini',
}
file 'Configs/Config.ini'