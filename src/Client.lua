

local QBCore = exports['qb-core']:GetCoreObject()

-- cHECKS IF PLAYER HAS ITEM ON HIM
RegisterNetEvent('hasPlayerItem', function(type)
  if type == "thermalvision" then
    if QBCore.Functions.HasItem(Config.ItemName2) == true then
      Citizen.Wait(0)
      TriggerEvent("hasHelmetOn2")
    end
  else
  if type == "nightvision" then 
      if QBCore.Functions.HasItem(Config.ItemName1) == true then
        Citizen.Wait(0)
          TriggerEvent("hasHelmetOn1")
          end
        end
      end
  end)


