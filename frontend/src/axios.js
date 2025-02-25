import axios from 'axios';

const axiosInstance = axios.create({
  baseURL: 'http://localhost:5250', // Se for usar HTTP (ajuste para o seu caso)
  // baseURL: 'https://localhost:7250', // Se for HTTPS
});

// Adiciona o token do localStorage (ou sessionStorage) nas requisições
axiosInstance.interceptors.request.use(config => {
  const token = localStorage.getItem('token'); // Ou sessionStorage.getItem('token')
  if (token) {
    config.headers['Authorization'] = `Bearer ${token}`;
  }
  return config;
});

export default axiosInstance;
