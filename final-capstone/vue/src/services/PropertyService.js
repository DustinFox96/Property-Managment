import axios from 'axios';

export default {

    getAllProperties() {
        return axios.get('/properties')
    },

    getAllUnits() {
        return axios.get('/units')
    },

    getAllUnitsById(propertyid) {
        return axios.get(`/unit/${propertyid}`)
    },

    addNewProperty(property) {
        return axios.post('/properties', property)
    },

    AddNewUnit(unit) {
        return axios.post('unit', unit);
    },

    getAllPropertiesByOwnerId() {
        return axios.get(`/Properties/owner`)
    }






}