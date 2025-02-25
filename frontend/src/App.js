import React, { useState, useEffect } from 'react';
import axiosInstance from './axios'; // Importando a instância do axios configurada

const App = () => {
  const [data, setData] = useState([]);
  
  useEffect(() => {
    // Fazendo uma requisição GET para a API
    axiosInstance.get('/api/rota') // O endpoint de sua API
      .then(response => setData(response.data))
      .catch(error => console.error('Erro ao buscar dados:', error));
  }, []);

  return (
    <div>
      <h1>Dados da API</h1>
      <ul>
        {data.map((item, index) => (
          <li key={index}>{item}</li>
        ))}
      </ul>
    </div>
  );
};

export default App;
